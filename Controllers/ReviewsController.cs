using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;

namespace Sakany.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly SakanyDbContext _context;

        public ReviewsController(SakanyDbContext context)
        {
            _context = context;
        }

        private string? SessionUserID => HttpContext.Session.GetString("UserID");
        private string? SessionRole => HttpContext.Session.GetString("UserRole");
        private bool IsLoggedIn => SessionUserID != null;
        private bool IsAdmin => SessionRole == "Admin";
        private bool IsOwner => SessionRole == "Owner";
        private bool IsTenant => SessionRole == "Tenant";

        // ── INDEX ─────────────────────────────────────────
        // Admin: all reviews. Owner: reviews on their properties. Tenant: their own reviews.
        public async Task<IActionResult> Index()
        {
            var query = _context.Review
                .Include(r => r.Client)
                .Include(r => r.Property)
                .Include(r => r.Request)
                .AsQueryable();

            if (IsOwner)
                query = query.Where(r => r.Property.OwnerID == SessionUserID);
            else if (IsTenant)
                query = query.Where(r => r.ClientID == SessionUserID);

            var reviews = await query.OrderByDescending(r => r.Date).ToListAsync();
            return View(reviews);
        }

        // ── DETAILS ───────────────────────────────────────
        public async Task<IActionResult> Details(string id)
        {
            if (id == null) return NotFound();

            var review = await _context.Review
                .Include(r => r.Client)
                .Include(r => r.Property)
                .Include(r => r.Request)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (review == null) return NotFound();

            // Tenant can only see their own review
            if (IsTenant && review.ClientID != SessionUserID)
            {
                TempData["Error"] = "You can only view your own reviews.";
                return RedirectToAction(nameof(Index));
            }

            return View(review);
        }

        // ── CREATE (Tenant only, must have Approved request, not yet reviewed) ──
        public async Task<IActionResult> Create(string? requestId, string? propertyId)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            if (!IsTenant)
            {
                TempData["Error"] = "Only tenants can write reviews.";
                return RedirectToAction(nameof(Index));
            }

            // Tenant: only show their approved, un-reviewed requests
            var approvedRequests = await _context.Request
                .Include(r => r.Property)
                .Where(r => r.ClientID == SessionUserID &&
                            r.Status == RequestStatus.Approved &&
                            !_context.Review.Any(rv => rv.RequestID == r.ID))
                .ToListAsync();

            if (!approvedRequests.Any())
            {
                TempData["Error"] = "You need an approved rental request to leave a review.";
                return RedirectToAction(nameof(Index));
            }

            ViewData["RequestID"] = new SelectList(
                approvedRequests.Select(r => new { r.ID, Display = r.Property?.Address ?? r.ID }),
                "ID", "Display", requestId);

            // Pre-fill PropertyID based on selected request
            if (!string.IsNullOrEmpty(requestId))
            {
                var req = approvedRequests.FirstOrDefault(r => r.ID == requestId);
                ViewBag.PreselectedPropertyId = req?.PropertyID;
                ViewBag.PreselectedPropertyAddress = req?.Property?.Address;
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequestID,Rate,Description")] Review review)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsTenant)
            {
                TempData["Error"] = "Only tenants can write reviews.";
                return RedirectToAction(nameof(Index));
            }

            ModelState.Remove("Client");
            ModelState.Remove("Property");
            ModelState.Remove("Request");
            ModelState.Remove("ID");
            ModelState.Remove("Date");
            ModelState.Remove("ClientID");
            ModelState.Remove("PropertyID");

            // Load and validate the request
            var request = await _context.Request
                .Include(r => r.Property)
                .FirstOrDefaultAsync(r => r.ID == review.RequestID);

            if (request == null || request.ClientID != SessionUserID)
                ModelState.AddModelError("", "Invalid request selected.");
            else if (request.Status != RequestStatus.Approved)
                ModelState.AddModelError("", "You can only review properties with an approved request.");
            else
            {
                var alreadyReviewed = await _context.Review
                    .AnyAsync(r => r.RequestID == review.RequestID);
                if (alreadyReviewed)
                    ModelState.AddModelError("", "You have already reviewed this request.");
            }

            if (ModelState.IsValid)
            {
                review.ID = Guid.NewGuid().ToString();
                review.ClientID = SessionUserID!;
                review.PropertyID = request!.PropertyID;
                review.Date = DateTime.Now;

                _context.Add(review);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Review submitted successfully!";
                return RedirectToAction(nameof(Index));
            }

            // Rebuild dropdown on failure
            var approvedRequests = await _context.Request
                .Include(r => r.Property)
                .Where(r => r.ClientID == SessionUserID &&
                            r.Status == RequestStatus.Approved &&
                            !_context.Review.Any(rv => rv.RequestID == r.ID))
                .ToListAsync();

            ViewData["RequestID"] = new SelectList(
                approvedRequests.Select(r => new { r.ID, Display = r.Property?.Address ?? r.ID }),
                "ID", "Display", review.RequestID);

            return View(review);
        }

        // ── EDIT (Tenant edits own review / Admin edits any) ──
        public async Task<IActionResult> Edit(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (id == null) return NotFound();

            var review = await _context.Review
                .Include(r => r.Property)
                .FirstOrDefaultAsync(r => r.ID == id);

            if (review == null) return NotFound();

            if (IsTenant && review.ClientID != SessionUserID)
            {
                TempData["Error"] = "You can only edit your own reviews.";
                return RedirectToAction(nameof(Index));
            }
            if (IsOwner)
            {
                TempData["Error"] = "Owners cannot edit reviews.";
                return RedirectToAction(nameof(Index));
            }

            return View(review);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Rate,Description")] Review review)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (IsOwner) return Forbid();
            if (id != review.ID) return NotFound();

            ModelState.Remove("Client");
            ModelState.Remove("Property");
            ModelState.Remove("Request");
            ModelState.Remove("ClientID");
            ModelState.Remove("PropertyID");
            ModelState.Remove("RequestID");
            ModelState.Remove("Date");

            if (ModelState.IsValid)
            {
                try
                {
                    var original = await _context.Review.AsNoTracking().FirstOrDefaultAsync(r => r.ID == id);
                    if (original == null) return NotFound();

                    if (IsTenant && original.ClientID != SessionUserID)
                    {
                        TempData["Error"] = "You can only edit your own reviews.";
                        return RedirectToAction(nameof(Index));
                    }

                    // Preserve locked fields
                    review.ClientID = original.ClientID;
                    review.PropertyID = original.PropertyID;
                    review.RequestID = original.RequestID;
                    review.Date = original.Date;

                    _context.Update(review);
                    await _context.SaveChangesAsync();
                    TempData["Success"] = "Review updated.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Review.Any(e => e.ID == id)) return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }

            return View(review);
        }

        // ── DELETE (Tenant deletes own / Admin deletes any) ──
        public async Task<IActionResult> Delete(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (id == null) return NotFound();

            var review = await _context.Review
                .Include(r => r.Client)
                .Include(r => r.Property)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (review == null) return NotFound();

            if (IsTenant && review.ClientID != SessionUserID)
            {
                TempData["Error"] = "You can only delete your own reviews.";
                return RedirectToAction(nameof(Index));
            }
            if (IsOwner)
            {
                TempData["Error"] = "Owners cannot delete reviews.";
                return RedirectToAction(nameof(Index));
            }

            return View(review);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (IsOwner) return Forbid();

            var review = await _context.Review.FindAsync(id);
            if (review != null)
            {
                if (IsTenant && review.ClientID != SessionUserID)
                {
                    TempData["Error"] = "You can only delete your own reviews.";
                    return RedirectToAction(nameof(Index));
                }
                _context.Review.Remove(review);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Review deleted.";
            }

            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(string id) => _context.Review.Any(e => e.ID == id);
    }
}