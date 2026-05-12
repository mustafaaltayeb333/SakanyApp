using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;

namespace Sakany.Controllers
{
    public class WishlistController : Controller
    {
        private readonly SakanyDbContext _context;

        public WishlistController(SakanyDbContext context)
        {
            _context = context;
        }

        // GET: Wishlist
        public async Task<IActionResult> Index()
        {
            // FIX: Use session instead of Claims (no auth middleware configured)
            var userId = HttpContext.Session.GetString("UserID");

            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Login", "Account");

            var wishlist = await _context.Wishlist
                .Include(w => w.Property)
                    .ThenInclude(p => p.Image)
                .Include(w => w.Property)
                    .ThenInclude(p => p.Owner)
                .Where(w => w.UserID == userId)
                .OrderByDescending(w => w.DateAdded)
                .ToListAsync();

            return View(wishlist);
        }

        // GET: Wishlist/Add
        public async Task<IActionResult> Add(string propertyId)
        {
            var userId = HttpContext.Session.GetString("UserID");

            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Login", "Account");

            if (string.IsNullOrEmpty(propertyId))
                return RedirectToAction("Index", "Property");

            // FIX: async check for existence
            var exists = await _context.Wishlist
                .AnyAsync(w => w.UserID == userId && w.PropertyID == propertyId);

            if (!exists)
            {
                // Verify property actually exists
                var propertyExists = await _context.Property.AnyAsync(p => p.ID == propertyId);
                if (!propertyExists)
                {
                    TempData["Error"] = "Property not found.";
                    return RedirectToAction("Index", "Property");
                }

                var wishlistItem = new Wishlist
                {
                    UserID = userId,
                    PropertyID = propertyId,
                    DateAdded = DateTime.Now
                };

                _context.Add(wishlistItem);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Property added to wishlist.";
            }
            else
            {
                TempData["Info"] = "This property is already in your wishlist.";
            }

            return RedirectToAction("Index", "Property");
        }

        // GET: Wishlist/Remove
        public async Task<IActionResult> Remove(string propertyId)
        {
            var userId = HttpContext.Session.GetString("UserID");

            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Login", "Account");

            // FIX: async lookup
            var item = await _context.Wishlist
                .FirstOrDefaultAsync(w => w.UserID == userId && w.PropertyID == propertyId);

            if (item != null)
            {
                _context.Wishlist.Remove(item);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Property removed from wishlist.";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
