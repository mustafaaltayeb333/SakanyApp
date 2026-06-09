using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;
using Sakany.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Sakany.Controllers
{
    public class ReportController : Controller
    {
        private readonly SakanyDbContext _context;
        private readonly INotificationService _notificationService;

        public ReportController(SakanyDbContext context, INotificationService notificationService)
        {
            _context = context;
            _notificationService = notificationService;
        }

        private string? SessionUserID => HttpContext.Session.GetString("UserID");
        private string? SessionRole => HttpContext.Session.GetString("UserRole");
        private bool IsLoggedIn => !string.IsNullOrEmpty(SessionUserID);
        private bool IsAdmin => SessionRole == "Admin";

        // ═══════════════════════════════════════════════════
        // INDEX
        // ═══════════════════════════════════════════════════
        public async Task<IActionResult> Index()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            var query = _context.Report
                .Include(r => r.Reporter)
                .Include(r => r.Property)
                .ThenInclude(p => p.Owner)
                .AsQueryable();

            if (!IsAdmin)
                query = query.Where(r => r.ReporterID == SessionUserID);

            return View(await query.OrderByDescending(r => r.CreatedAt).ToListAsync());
        }

        // ═══════════════════════════════════════════════════
        // DETAILS
        // ═══════════════════════════════════════════════════
        public async Task<IActionResult> Details(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (id == null) return NotFound();

            var report = await _context.Report
                .Include(r => r.Reporter)
                .Include(r => r.Property)
                .ThenInclude(p => p.Owner)
                .Include(r => r.Property)
                .ThenInclude(p => p.Image)
                .FirstOrDefaultAsync(r => r.ID == id);

            if (report == null) return NotFound();

            if (!IsAdmin && report.ReporterID != SessionUserID)
            {
                TempData["Error"] = "Access denied.";
                return RedirectToAction(nameof(Index));
            }

            return View(report);
        }

        // ═══════════════════════════════════════════════════
        // CREATE GET
        // ═══════════════════════════════════════════════════
        public async Task<IActionResult> Create(string? propertyId)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            var properties = await _context.Property
                .Where(p => p.Status != PropertyStatus.Sold)
                .OrderBy(p => p.City)
                .ToListAsync();

            ViewData["PropertyID"] = new SelectList(
                properties.Select(p => new { p.ID, Display = $"{p.Address}, {p.City}" }),
                "ID", "Display", propertyId);

            return View();
        }

        // ═══════════════════════════════════════════════════
        // CREATE POST
        // ═══════════════════════════════════════════════════
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PropertyID,Reason")] Report report)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            ModelState.Remove("ID");
            ModelState.Remove("Reporter");
            ModelState.Remove("Property");
            ModelState.Remove("CreatedAt");

            if (ModelState.IsValid)
            {
                report.ID = Guid.NewGuid().ToString();
                report.ReporterID = SessionUserID!;
                report.CreatedAt = DateTime.Now;
                report.Status = ReportStatus.Pending;

                _context.Add(report);
                await _context.SaveChangesAsync();

                await _notificationService.NotifyAdminsAsync(
                    "New Report Submitted",
                    $"A new report has been filed for {report.Property?.Address ?? "a property"}.",
                    NotificationPriority.High,
                    $"/Report/Details/{report.ID}",
                    "Review Report");

                TempData["Success"] = "Report submitted successfully.";
                return RedirectToAction(nameof(Index));
            }

            var props = await _context.Property
                .Where(p => p.Status != PropertyStatus.Sold)
                .ToListAsync();
            ViewData["PropertyID"] = new SelectList(
                props.Select(p => new { p.ID, Display = $"{p.Address}, {p.City}" }),
                "ID", "Display", report.PropertyID);

            return View(report);
        }

        // ═══════════════════════════════════════════════════
        // EDIT GET (Admin only)
        // ═══════════════════════════════════════════════════
        public async Task<IActionResult> Edit(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin)
            {
                TempData["Error"] = "Only administrators can edit reports.";
                return RedirectToAction(nameof(Index));
            }
            if (id == null) return NotFound();

            var report = await _context.Report
                .Include(r => r.Reporter)
                .Include(r => r.Property)
                .FirstOrDefaultAsync(r => r.ID == id);

            if (report == null) return NotFound();

            return View(report);
        }

        // ═══════════════════════════════════════════════════
        // EDIT POST (Admin only)
        // ═══════════════════════════════════════════════════
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Status")] Report report)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin)
            {
                TempData["Error"] = "Only administrators can edit reports.";
                return RedirectToAction(nameof(Index));
            }
            if (id != report.ID) return NotFound();

            ModelState.Remove("Reporter");
            ModelState.Remove("Property");
            ModelState.Remove("Reason");
            ModelState.Remove("PropertyID");
            ModelState.Remove("ReporterID");
            ModelState.Remove("CreatedAt");

            if (ModelState.IsValid)
            {
                try
                {
                    var existing = await _context.Report
                        .AsNoTracking()
                        .FirstOrDefaultAsync(r => r.ID == id);

                    if (existing == null) return NotFound();

                    existing.Status = report.Status;

                    _context.Update(existing);
                    await _context.SaveChangesAsync();

                    string statusMessage = report.Status switch
                    {
                        ReportStatus.Reviewed => "is now under review",
                        ReportStatus.Dismissed => "has been dismissed",
                        _ => "status updated"
                    };

                    await _notificationService.NotifyUserAsync(
                        existing.ReporterID,
                        "Report Status Updated",
                        $"Your report for {existing.PropertyID} {statusMessage}.",
                        NotificationPriority.Normal,
                        $"/Report/Details/{existing.ID}",
                        "View Report");

                    TempData["Success"] = "Report updated successfully.";
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportExists(report.ID)) return NotFound();
                    throw;
                }
            }

            var fullReport = await _context.Report
                .Include(r => r.Reporter)
                .Include(r => r.Property)
                .FirstOrDefaultAsync(r => r.ID == id);

            return View(fullReport);
        }

        // ═══════════════════════════════════════════════════
        // DELETE (Admin only)
        // ═══════════════════════════════════════════════════
        public async Task<IActionResult> Delete(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin)
            {
                TempData["Error"] = "Only administrators can delete reports.";
                return RedirectToAction(nameof(Index));
            }
            if (id == null) return NotFound();

            var report = await _context.Report
                .Include(r => r.Reporter)
                .Include(r => r.Property)
                .FirstOrDefaultAsync(r => r.ID == id);

            if (report == null) return NotFound();

            return View(report);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin)
            {
                TempData["Error"] = "Only administrators can delete reports.";
                return RedirectToAction(nameof(Index));
            }

            var report = await _context.Report.FindAsync(id);
            if (report != null)
            {
                _context.Report.Remove(report);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Report deleted.";
            }

            return RedirectToAction(nameof(Index));
        }

        private bool ReportExists(string id)
        {
            return _context.Report.Any(e => e.ID == id);
        }
    }
}