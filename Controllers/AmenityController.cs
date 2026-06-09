using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;

namespace Sakany.Controllers
{
    public class AmenityController : Controller
    {
        private readonly SakanyDbContext _context;

        public AmenityController(SakanyDbContext context)
        {
            _context = context;
        }

        private string? SessionUserID => HttpContext.Session.GetString("UserID");
        private string? SessionRole => HttpContext.Session.GetString("UserRole");
        private bool IsLoggedIn => SessionUserID != null;
        private bool IsAdmin => SessionRole == "Admin";

        // ── Guard: redirect unauthenticated or non-admin users ─
        private IActionResult? AdminGuard()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin) { TempData["Error"] = "Only administrators can manage amenities."; return RedirectToAction("Index", "Home"); }
            return null;
        }

        // ── INDEX ─────────────────────────────────────────
        public async Task<IActionResult> Index()
        {
            var guard = AdminGuard();
            if (guard != null) return guard;

            return View(await _context.Amenity.OrderBy(a => a.Name).ToListAsync());
        }

        // ── DETAILS ───────────────────────────────────────
        public async Task<IActionResult> Details(string id)
        {
            var guard = AdminGuard();
            if (guard != null) return guard;
            if (id == null) return NotFound();

            var amenity = await _context.Amenity
                .Include(a => a.Property_Amenity)
                .FirstOrDefaultAsync(a => a.ID == id);

            if (amenity == null) return NotFound();

            return View(amenity);
        }

        // ── CREATE GET ────────────────────────────────────
        public IActionResult Create()
        {
            var guard = AdminGuard();
            if (guard != null) return guard;

            return View();
        }

        // ── CREATE POST ───────────────────────────────────
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name")] Amenity amenity)
        {
            var guard = AdminGuard();
            if (guard != null) return guard;

            ModelState.Remove("PropertyAmenity");
            ModelState.Remove("ID");

            // Check for duplicate name
            var nameExists = await _context.Amenity
                .AnyAsync(a => a.Name.ToLower() == amenity.Name.ToLower());
            if (nameExists)
            {
                ModelState.AddModelError("Name", "An amenity with this name already exists.");
            }

            if (ModelState.IsValid)
            {
                amenity.ID = Guid.NewGuid().ToString();
                _context.Add(amenity);
                await _context.SaveChangesAsync();

                TempData["Success"] = $"Amenity '{amenity.Name}' created successfully.";
                return RedirectToAction(nameof(Index));
            }

            return View(amenity);
        }

        // ── EDIT GET ──────────────────────────────────────
        public async Task<IActionResult> Edit(string id)
        {
            var guard = AdminGuard();
            if (guard != null) return guard;
            if (id == null) return NotFound();

            var amenity = await _context.Amenity.FindAsync(id);
            if (amenity == null) return NotFound();

            return View(amenity);
        }

        // ── EDIT POST ─────────────────────────────────────
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Name")] Amenity amenity)
        {
            var guard = AdminGuard();
            if (guard != null) return guard;
            if (id != amenity.ID) return NotFound();

            ModelState.Remove("PropertyAmenity");

            // Check for duplicate name (excluding current record)
            var nameExists = await _context.Amenity
                .AnyAsync(a => a.Name.ToLower() == amenity.Name.ToLower() && a.ID != id);
            if (nameExists)
            {
                ModelState.AddModelError("Name", "An amenity with this name already exists.");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(amenity);
                    await _context.SaveChangesAsync();
                    TempData["Success"] = $"Amenity '{amenity.Name}' updated successfully.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AmenityExists(amenity.ID))
                        return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }

            return View(amenity);
        }

        // ── DELETE GET ────────────────────────────────────
        public async Task<IActionResult> Delete(string id)
        {
            var guard = AdminGuard();
            if (guard != null) return guard;
            if (id == null) return NotFound();

            var amenity = await _context.Amenity
                .Include(a => a.Property_Amenity)
                .FirstOrDefaultAsync(a => a.ID == id);

            if (amenity == null) return NotFound();

            // Check if amenity is in use
            var usageCount = await _context.PropertyAmenity.CountAsync(pa => pa.AmenityID == id);
            ViewBag.UsageCount = usageCount;

            return View(amenity);
        }

        // ── DELETE POST ───────────────────────────────────
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var guard = AdminGuard();
            if (guard != null) return guard;

            var amenity = await _context.Amenity
                .Include(a => a.Property_Amenity)
                .FirstOrDefaultAsync(a => a.ID == id);

            if (amenity != null)
            {
                // Remove all property-amenity associations first
                if (amenity.Property_Amenity?.Any() == true)
                {
                    _context.PropertyAmenity.RemoveRange(amenity.Property_Amenity);
                }

                _context.Amenity.Remove(amenity);
                await _context.SaveChangesAsync();
                TempData["Success"] = $"Amenity '{amenity.Name}' deleted successfully.";
            }

            return RedirectToAction(nameof(Index));
        }

        private bool AmenityExists(string id)
        {
            return _context.Amenity.Any(e => e.ID == id);
        }
    }
}
