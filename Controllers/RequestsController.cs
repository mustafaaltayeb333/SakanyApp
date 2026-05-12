using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;
using Sakany.Services;

namespace Sakany.Controllers
{
    public class RequestsController : Controller
    {
        private readonly SakanyDbContext _context;
        private readonly PdfService _pdfService;
        private readonly EmailService _emailService;

        public RequestsController(SakanyDbContext context,
                                  PdfService pdfService,
                                  EmailService emailService)
        {
            _context = context;
            _pdfService = pdfService;
            _emailService = emailService;
        }

        private string? SessionUserID => HttpContext.Session.GetString("UserID");
        private string? SessionRole => HttpContext.Session.GetString("UserRole");
        private bool IsLoggedIn => SessionUserID != null;
        private bool IsAdmin => SessionRole == "Admin";
        private bool IsOwner => SessionRole == "Owner";
        private bool IsTenant => SessionRole == "Tenant";

        // ── INDEX ─────────────────────────────────────────
        public async Task<IActionResult> Index()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            var query = _context.Request
                .Include(r => r.Client)
                .Include(r => r.Property)
                    .ThenInclude(p => p.Owner)
                .AsQueryable();

            if (IsOwner)
                query = query.Where(r => r.Property.OwnerID == SessionUserID);
            else if (IsTenant)
                query = query.Where(r => r.ClientID == SessionUserID);

            var requests = await query.OrderByDescending(r => r.Date).ToListAsync();
            return View(requests);
        }

        // ── DETAILS ───────────────────────────────────────
        public async Task<IActionResult> Details(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (id == null) return NotFound();

            var request = await _context.Request
                .Include(r => r.Client)
                .Include(r => r.Property)
                    .ThenInclude(p => p.Owner)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (request == null) return NotFound();

            if (IsTenant && request.ClientID != SessionUserID)
            { TempData["Error"] = "Access denied."; return RedirectToAction(nameof(Index)); }

            if (IsOwner && request.Property?.OwnerID != SessionUserID)
            { TempData["Error"] = "Access denied."; return RedirectToAction(nameof(Index)); }

            return View(request);
        }

        // ── CREATE (Tenant only) ───────────────────────────
        public async Task<IActionResult> Create(string? propertyId)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            if (!IsTenant)
            {
                TempData["Error"] = "Only tenants can submit rental requests.";
                return RedirectToAction(nameof(Index));
            }

            var available = await _context.Property
                .Where(p => p.Status == PropertyStatus.Available && p.AvailableRooms > 0)
                .OrderBy(p => p.City)
                .ToListAsync();

            ViewData["PropertyID"] = new SelectList(
                available.Select(p => new
                {
                    p.ID,
                    Display = $"{p.Address} — {p.City} (EGP {p.Price:N0})"
                }),
                "ID", "Display", propertyId);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PropertyID")] Request request)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsTenant)
            {
                TempData["Error"] = "Only tenants can submit requests.";
                return RedirectToAction(nameof(Index));
            }

            ModelState.Remove("Client"); ModelState.Remove("Property");
            ModelState.Remove("Review"); ModelState.Remove("Contract");
            ModelState.Remove("ID"); ModelState.Remove("Date");
            ModelState.Remove("ClientID");

            request.ClientID = SessionUserID!;

            var property = await _context.Property.FindAsync(request.PropertyID);
            if (property == null)
                ModelState.AddModelError("", "Property not found.");
            else
            {
                if (property.Status != PropertyStatus.Available)
                    ModelState.AddModelError("", "This property is no longer available.");
                if (property.AvailableRooms <= 0)
                    ModelState.AddModelError("", "No available rooms in this property.");
                var alreadyPending = await _context.Request.AnyAsync(r =>
                    r.ClientID == SessionUserID &&
                    r.PropertyID == request.PropertyID &&
                    r.Status == RequestStatus.Pending);
                if (alreadyPending)
                    ModelState.AddModelError("", "You already have a pending request for this property.");
            }

            if (ModelState.IsValid)
            {
                request.ID = Guid.NewGuid().ToString();
                request.Date = DateTime.Now;
                request.Status = RequestStatus.Pending;
                _context.Add(request);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Rental request submitted!";
                return RedirectToAction(nameof(Index));
            }

            var avail = await _context.Property
                .Where(p => p.Status == PropertyStatus.Available && p.AvailableRooms > 0)
                .ToListAsync();
            ViewData["PropertyID"] = new SelectList(
                avail.Select(p => new
                {
                    p.ID,
                    Display = $"{p.Address} — {p.City} (EGP {p.Price:N0})"
                }),
                "ID", "Display", request.PropertyID);

            return View(request);
        }

        // ── EDIT (Owner approves/rejects / Admin / Tenant cannot) ────────────
        public async Task<IActionResult> Edit(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (IsTenant)
            {
                TempData["Error"] = "Tenants cannot edit requests.";
                return RedirectToAction(nameof(Index));
            }
            if (id == null) return NotFound();

            var request = await _context.Request
                .Include(r => r.Client)
                .Include(r => r.Property)
                .FirstOrDefaultAsync(r => r.ID == id);

            if (request == null) return NotFound();

            if (IsOwner && request.Property?.OwnerID != SessionUserID)
            {
                TempData["Error"] = "You can only manage your own property requests.";
                return RedirectToAction(nameof(Index));
            }

            return View(request);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Status")] Request request)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (IsTenant)
            {
                TempData["Error"] = "Tenants cannot edit requests.";
                return RedirectToAction(nameof(Index));
            }
            if (id != request.ID) return NotFound();

            ModelState.Remove("Client"); ModelState.Remove("Property");
            ModelState.Remove("Review"); ModelState.Remove("Contract");
            ModelState.Remove("ClientID"); ModelState.Remove("PropertyID");
            ModelState.Remove("Date");

            if (ModelState.IsValid)
            {
                try
                {
                    var original = await _context.Request
                        .AsNoTracking()
                        .FirstOrDefaultAsync(r => r.ID == id);
                    if (original == null) return NotFound();

                    if (IsOwner)
                    {
                        var prop = await _context.Property.FindAsync(original.PropertyID);
                        if (prop?.OwnerID != SessionUserID)
                        {
                            TempData["Error"] = "Access denied.";
                            return RedirectToAction(nameof(Index));
                        }
                    }

                    // ── PENDING → APPROVED ────────────────────────────
                    if (original.Status == RequestStatus.Pending &&
                        request.Status == RequestStatus.Approved)
                    {
                        // تحقق إن مفيش contract موجود بالفعل لهذا الـ request
                        var existingContract = await _context.Contract
                            .FirstOrDefaultAsync(c => c.RequestID == original.ID);

                        if (existingContract != null)
                        {
                            TempData["Warning"] = "A contract already exists for this request.";
                        }
                        else
                        {
                            // 1) Decrement available rooms
                            var property = await _context.Property.FindAsync(original.PropertyID);
                            if (property == null || property.AvailableRooms <= 0)
                            {
                                TempData["Error"] = "No available rooms to approve.";
                                return RedirectToAction(nameof(Index));
                            }

                            property.AvailableRooms -= 1;
                            if (property.AvailableRooms == 0)
                                property.Status = PropertyStatus.Rented;

                            // 2) Create Contract
                            var contract = new Contract
                            {
                                ID = Guid.NewGuid().ToString(),
                                RequestID = original.ID,
                                OwnerID = property.OwnerID,
                                TenantID = original.ClientID,
                                PropertyID = property.ID,
                                StartDate = DateTime.Now,
                                EndDate = null,
                                Amount = property.Price,
                                Status = ContractStatus.Active
                            };

                            _context.Add(contract);
                            await _context.SaveChangesAsync();

                            // 3) Load navigation props for PDF
                            var fullContract = await _context.Contract
                                .Include(c => c.Owner)
                                .Include(c => c.Tenant)
                                .Include(c => c.Property)
                                .FirstAsync(c => c.ID == contract.ID);

                            // 4) Generate PDF
                            byte[] pdf = _pdfService.GenerateContractPdf(fullContract);

                            string subject = $"Sakany — Your Rental Contract #{fullContract.ID[..8].ToUpper()}";

                            string ownerBody = $"""
                                <p>Dear <strong>{fullContract.Owner?.Name}</strong>,</p>
                                <p>A rental contract has been created for your property at
                                   <strong>{fullContract.Property?.Address}, {fullContract.Property?.City}</strong>.</p>
                                <p>Please find the contract PDF attached.</p>
                                <br/>
                                <p style="color:#888;font-size:12px;">— Sakany Team</p>
                                """;

                            string tenantBody = $"""
                                <p>Dear <strong>{fullContract.Tenant?.Name}</strong>,</p>
                                <p>Congratulations! Your rental request has been approved for
                                   <strong>{fullContract.Property?.Address}, {fullContract.Property?.City}</strong>.</p>
                                <p>Please find your rental contract PDF attached.</p>
                                <br/>
                                <p style="color:#888;font-size:12px;">— Sakany Team</p>
                                """;

                            string fileName = $"contract_{fullContract.ID[..8].ToUpper()}.pdf";

                            // 5) Send emails
                            try
                            {
                                await _emailService.SendEmailWithAttachmentAsync(
                                    fullContract.Owner!.Email,
                                    fullContract.Owner.Name,
                                    subject, ownerBody,
                                    pdf, fileName);

                                await _emailService.SendEmailWithAttachmentAsync(
                                    fullContract.Tenant!.Email,
                                    fullContract.Tenant.Name,
                                    subject, tenantBody,
                                    pdf, fileName);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"[Email Error] {ex.Message}");
                                TempData["Warning"] = "Request approved and contract created, but email could not be sent.";
                            }
                        }
                    }

                    // ── SAVE REQUEST STATUS ───────────────────────────
                    request.ClientID = original.ClientID;
                    request.PropertyID = original.PropertyID;
                    request.Date = original.Date;

                    _context.Update(request);
                    await _context.SaveChangesAsync();

                    if (TempData["Warning"] == null)
                        TempData["Success"] = $"Request marked as {request.Status}.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequestExists(request.ID)) return NotFound();
                    throw;
                }

                return RedirectToAction(nameof(Index));
            }

            var full = await _context.Request
                .Include(r => r.Client)
                .Include(r => r.Property)
                .FirstOrDefaultAsync(r => r.ID == id);
            return View(full);
        }

        // ── DELETE (Admin only) ────────────────────────────
        public async Task<IActionResult> Delete(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin)
            {
                TempData["Error"] = "Only admins can delete requests.";
                return RedirectToAction(nameof(Index));
            }
            if (id == null) return NotFound();

            var request = await _context.Request
                .Include(r => r.Client)
                .Include(r => r.Property)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (request == null) return NotFound();
            return View(request);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin)
            {
                TempData["Error"] = "Only admins can delete requests.";
                return RedirectToAction(nameof(Index));
            }

            var request = await _context.Request.FindAsync(id);
            if (request != null)
            {
                _context.Request.Remove(request);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Request deleted.";
            }
            return RedirectToAction(nameof(Index));
        }

        private bool RequestExists(string id) =>
            _context.Request.Any(e => e.ID == id);
    }
}