using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;

namespace Sakany.Controllers
{
    public class DashboardController : Controller
    {
        private readonly SakanyDbContext _context;

        public DashboardController(SakanyDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Counts
            ViewBag.UsersCount = await _context.User.CountAsync();
            ViewBag.PropertiesCount = await _context.Property.CountAsync();
            ViewBag.RequestsCount = await _context.Request.CountAsync();
            ViewBag.ReviewsCount = await _context.Review.CountAsync();
            ViewBag.ContractsCount = await _context.Contract.CountAsync();
            ViewBag.ReportsCount = await _context.Report.CountAsync();

            // Status breakdowns
            ViewBag.AvailableProperties = await _context.Property
                .CountAsync(p => p.Status == PropertyStatus.Available);
            ViewBag.RentedProperties = await _context.Property
                .CountAsync(p => p.Status == PropertyStatus.Rented);
            ViewBag.PendingRequests = await _context.Request
                .CountAsync(r => r.Status == RequestStatus.Pending);
            ViewBag.ApprovedRequests = await _context.Request
                .CountAsync(r => r.Status == RequestStatus.Approved);

            // Role breakdown
            ViewBag.AdminCount = await _context.User.CountAsync(u => u.Role == UserRole.Admin);
            ViewBag.OwnerCount = await _context.User.CountAsync(u => u.Role == UserRole.Owner);
            ViewBag.TenantCount = await _context.User.CountAsync(u => u.Role == UserRole.Tenant);

            // Recent activity
            var recentRequests = await _context.Request
                .Include(r => r.Client)
                .Include(r => r.Property)
                .OrderByDescending(r => r.Date)
                .Take(5)
                .ToListAsync();

            var recentProperties = await _context.Property
                .Include(p => p.Owner)
                .OrderByDescending(p => p.CreatedAt)
                .Take(5)
                .ToListAsync();

            var recentReports = await _context.Report
                .Include(r => r.Reporter)
                .Include(r => r.Property)
                .OrderByDescending(r => r.CreatedAt)
                .Take(5)
                .ToListAsync();

            ViewBag.RecentRequests = recentRequests;
            ViewBag.RecentProperties = recentProperties;
            ViewBag.RecentReports = recentReports;

            // Average review rating
            var avgRating = await _context.Review.AverageAsync(r => (double?)r.Rate) ?? 0;
            ViewBag.AvgRating = Math.Round(avgRating, 1);

            return View();
        }
    }
}
