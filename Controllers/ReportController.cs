using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;

namespace Sakany.Controllers
{
    public class ReportController : Controller
    {
        private readonly SakanyDbContext _context;

        public ReportController(SakanyDbContext context)
        {
            _context = context;
        }

        private string? SessionUserID => HttpContext.Session.GetString("UserID");
        private string? SessionRole => HttpContext.Session.GetString("UserRole");
        private bool IsLoggedIn => SessionUserID != null;
        private bool IsAdmin => SessionRole == "Admin";

        // ── INDEX ─────────────────────────────────────────
        public async Task<IActionResult> Index()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            var query = _context.Report
                .Include(r => r.Reporter)
                .Include(r => r.Property)
                .AsQueryable();

            if (!IsAdmin)
                query = query.Where(r => r.ReporterID == SessionUserID);

            return View(await query.OrderByDescending(r => r.CreatedAt).ToListAsync());
        }

        // ── DETAILS ───────────────────────────────────────
        public async Task<IActionResult> Details(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (id == null) return NotFound();

            var report = await _context.Report
                .Include(r => r.Reporter)
                .Include(r => r.Property)
                .FirstOrDefaultAsync(r => r.ID == id);

            if (report == null) return NotFound();

            // Users can only view their own reports unless they're Admin
            if (!IsAdmin && report.ReporterID != SessionUserID)
            {
                TempData["Error"] = "Access denied. You can only view your own reports.";
                return RedirectToAction(nameof(Index));
            }

            return View(report);
        }

        // ── CREATE GET ────────────────────────────────────
        public async Task<IActionResult> Create(string? propertyId = null)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            // Build property dropdown - filter by user's properties if owner
            var propertiesQuery = _context.Property.AsQueryable();
            if (SessionRole == "Owner")
                propertiesQuery = propertiesQuery.Where(p => p.OwnerID == SessionUserID);

            var properties = await propertiesQuery
                .OrderBy(p => p.City)
                .ThenBy(p => p.Address)
                .Select(p => new {
                    p.ID,
                    Display = $"{p.Address} - {p.City} ({p.Type})"
                })
                .ToListAsync();

            ViewData["PropertyID"] = new SelectList(properties, "ID", "Display", propertyId);

            // Pre-select property if provided
            var report = new Report
            {
                PropertyID = propertyId ?? ""
            };

            return View(report);
        }

        // ── CREATE POST ───────────────────────────────────
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PropertyID,Reason")] Report report)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            ModelState.Remove("Reporter");
            ModelState.Remove("Property");
            ModelState.Remove("ID");
            ModelState.Remove("Status");
            ModelState.Remove("CreatedAt");
            ModelState.Remove("ReporterID");

            // Validate the property exists and belongs to owner if owner role
            var property = await _context.Property.FindAsync(report.PropertyID);
            if (property == null)
            {
                ModelState.AddModelError("PropertyID", "Selected property not found.");
            }
            else if (SessionRole == "Owner" && property.OwnerID != SessionUserID)
            {
                ModelState.AddModelError("PropertyID", "You can only report issues for your own properties.");
            }

            if (ModelState.IsValid)
            {
                report.ID = Guid.NewGuid().ToString();
                report.ReporterID = SessionUserID!;
                report.Status = ReportStatus.Pending;
                report.CreatedAt = DateTime.Now;

                _context.Add(report);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Report submitted successfully. An administrator will review it shortly.";
                return RedirectToAction(nameof(Index));
            }

            // Rebuild dropdown on error
            var propertiesQuery = _context.Property.AsQueryable();
            if (SessionRole == "Owner")
                propertiesQuery = propertiesQuery.Where(p => p.OwnerID == SessionUserID);

            var properties = await propertiesQuery
                .OrderBy(p => p.City)
                .ThenBy(p => p.Address)
                .Select(p => new {
                    p.ID,
                    Display = $"{p.Address} - {p.City} ({p.Type})"
                })
                .ToListAsync();

            ViewData["PropertyID"] = new SelectList(properties, "ID", "Display", report.PropertyID);

            return View(report);
        }

        // ── EDIT (Admin only - update status) ─────────────
        public async Task<IActionResult> Edit(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin) { TempData["Error"] = "Only administrators can update report status."; return RedirectToAction(nameof(Index)); }
            if (id == null) return NotFound();

            var report = await _context.Report
                .Include(r => r.Reporter)
                .Include(r => r.Property)
                .FirstOrDefaultAsync(r => r.ID == id);

            if (report == null) return NotFound();

            return View(report);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, ReportStatus status)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin) return Forbid();

            var report = await _context.Report.FindAsync(id);
            if (report == null) return NotFound();

            report.Status = status;
            _context.Update(report);
            await _context.SaveChangesAsync();

            TempData["Success"] = "Report status updated.";
            return RedirectToAction(nameof(Index));
        }

        // ── DELETE ────────────────────────────────────────
        public async Task<IActionResult> Delete(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (id == null) return NotFound();

            var report = await _context.Report
                .Include(r => r.Reporter)
                .Include(r => r.Property)
                .FirstOrDefaultAsync(r => r.ID == id);

            if (report == null) return NotFound();

            // Only Admin or the reporter can delete
            if (!IsAdmin && report.ReporterID != SessionUserID)
            {
                TempData["Error"] = "Access denied.";
                return RedirectToAction(nameof(Index));
            }

            return View(report);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            var report = await _context.Report.FindAsync(id);
            if (report != null)
            {
                // Only Admin or the reporter can delete
                if (!IsAdmin && report.ReporterID != SessionUserID)
                {
                    TempData["Error"] = "Access denied.";
                    return RedirectToAction(nameof(Index));
                }

                _context.Report.Remove(report);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Report deleted.";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
