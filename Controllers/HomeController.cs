using Microsoft.AspNetCore.Mvc;
using Sakany.Data;
using Sakany.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Sakany.Controllers
{
    public class HomeController : Controller
    {
        private readonly SakanyDbContext _context;

        public HomeController(SakanyDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string? city, string? type)
        {
            ViewBag.UsersCount = await _context.User.CountAsync();
            ViewBag.PropertiesCount = await _context.Property.CountAsync();
            ViewBag.RequestsCount = await _context.Request.CountAsync();
            ViewBag.ReviewsCount = await _context.Review.CountAsync();

            // For search bar dropdowns
            ViewBag.Cities = await _context.Property
                .Select(p => p.City)
                .Distinct()
                .OrderBy(c => c)
                .ToListAsync();

            var query = _context.Property
                .Include(p => p.Owner)
                .Include(p => p.Image)
                .Where(p => p.Status == PropertyStatus.Available)
                .AsQueryable();

            if (!string.IsNullOrEmpty(city))
                query = query.Where(p => p.City == city);

            if (!string.IsNullOrEmpty(type) && Enum.TryParse<PropertyType>(type, out var parsedType))
                query = query.Where(p => p.Type == parsedType);

            var latestProperties = await query
                .OrderByDescending(p => p.CreatedAt)
                .Take(6)
                .ToListAsync();

            ViewBag.SelectedCity = city;
            ViewBag.SelectedType = type;

            return View(latestProperties);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}