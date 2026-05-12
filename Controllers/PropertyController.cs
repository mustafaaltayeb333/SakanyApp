using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;

namespace Sakany.Controllers
{
    public class PropertyController : Controller
    {
        private readonly SakanyDbContext _context;

        public PropertyController(SakanyDbContext context)
        {
            _context = context;
        }

        // ── HELPERS ──────────────────────────────────────
        private string? SessionUserID => HttpContext.Session.GetString("UserID");
        private string? SessionRole => HttpContext.Session.GetString("UserRole");
        private bool IsLoggedIn => SessionUserID != null;
        private bool IsAdmin => SessionRole == "Admin";
        private bool IsOwner => SessionRole == "Owner";
        private bool IsTenant => SessionRole == "Tenant";

        // ── INDEX ─────────────────────────────────────────
        public async Task<IActionResult> Index(string? city, string? type, string? status,
                                               decimal? minPrice, decimal? maxPrice,
                                               int pageNumber = 1)
        {
            int pageSize = 9;

            var query = _context.Property
                .Include(p => p.Owner)
                .Include(p => p.Image)
                .Include(p => p.PropertyAmenity)
                    .ThenInclude(pa => pa.Amenity)
                .AsQueryable();

            // Owner sees ONLY their own listings
            if (IsOwner && !IsAdmin)
                query = query.Where(p => p.OwnerID == SessionUserID);

            // Tenant sees only Available
            if (IsTenant)
                query = query.Where(p => p.Status == PropertyStatus.Available);

            if (!string.IsNullOrEmpty(city))
                query = query.Where(p => p.City == city);

            if (!string.IsNullOrEmpty(type) && Enum.TryParse<PropertyType>(type, out var pt))
                query = query.Where(p => p.Type == pt);

            if (!string.IsNullOrEmpty(status) && Enum.TryParse<PropertyStatus>(status, out var ps))
                query = query.Where(p => p.Status == ps);

            if (minPrice.HasValue)
                query = query.Where(p => p.Price >= minPrice);

            if (maxPrice.HasValue)
                query = query.Where(p => p.Price <= maxPrice);

            // ── PAGINATION ────────────────────────────────
            int totalCount = await query.CountAsync();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            // Clamp pageNumber
            if (pageNumber < 1) pageNumber = 1;
            if (pageNumber > totalPages && totalPages > 0) pageNumber = totalPages;

            var properties = await query
                .OrderByDescending(p => p.CreatedAt)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            ViewBag.CurrentPage = pageNumber;
            ViewBag.TotalPages = totalPages;
            ViewBag.TotalCount = totalCount;

            // ── FILTER DROPDOWNS ──────────────────────────
            ViewBag.Cities = await _context.Property.Select(p => p.City).Distinct().OrderBy(c => c).ToListAsync();
            ViewBag.Types = Enum.GetNames(typeof(PropertyType));
            ViewBag.Statuses = Enum.GetNames(typeof(PropertyStatus));

            // Pass current filter values back
            ViewBag.CurrentCity = city;
            ViewBag.CurrentType = type;
            ViewBag.CurrentStatus = status;
            ViewBag.CurrentMinPrice = minPrice;
            ViewBag.CurrentMaxPrice = maxPrice;

            // Wishlist IDs for the current tenant (to show filled heart)
            if (IsTenant && IsLoggedIn)
            {
                var wishlistIds = await _context.Wishlist
                    .Where(w => w.UserID == SessionUserID)
                    .Select(w => w.PropertyID)
                    .ToListAsync();
                ViewBag.WishlistIds = wishlistIds;
            }
            else
            {
                ViewBag.WishlistIds = new List<string>();
            }

            return View(properties);
        }

        // ── DETAILS ───────────────────────────────────────
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null) return NotFound();

            var property = await _context.Property
                .Include(p => p.Owner)
                .Include(p => p.Image)
                .Include(p => p.PropertyAmenity)
                    .ThenInclude(pa => pa.Amenity)
                .Include(p => p.Reviews)
                    .ThenInclude(r => r.Client)
                .FirstOrDefaultAsync(p => p.ID == id);

            if (property == null) return NotFound();

            if (IsTenant && IsLoggedIn)
            {
                ViewBag.IsInWishlist = await _context.Wishlist
                    .AnyAsync(w => w.UserID == SessionUserID && w.PropertyID == id);

                ViewBag.HasPendingRequest = await _context.Request
                    .AnyAsync(r => r.ClientID == SessionUserID &&
                                   r.PropertyID == id &&
                                   r.Status == RequestStatus.Pending);

                ViewBag.ApprovedRequestId = await _context.Request
                    .Where(r => r.ClientID == SessionUserID &&
                                r.PropertyID == id &&
                                r.Status == RequestStatus.Approved)
                    .Select(r => r.ID)
                    .FirstOrDefaultAsync();

                ViewBag.HasReviewed = await _context.Review
                    .AnyAsync(r => r.ClientID == SessionUserID && r.PropertyID == id);
            }

            if (IsOwner && property.OwnerID == SessionUserID)
            {
                ViewBag.PendingRequestCount = await _context.Request
                    .CountAsync(r => r.PropertyID == id && r.Status == RequestStatus.Pending);
            }

            return View(property);
        }

        // ── CREATE (Owner / Admin only) ───────────────────
        public IActionResult Create()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (IsTenant)
            {
                TempData["Error"] = "Only property owners can list properties.";
                return RedirectToAction(nameof(Index));
            }

            if (IsOwner)
                ViewBag.OwnerID = SessionUserID;
            else
                ViewData["OwnerID"] = new SelectList(
                    _context.User.Where(u => u.Role == UserRole.Owner), "ID", "Name");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Property property)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (IsTenant) return Forbid();

            ModelState.Remove("Owner");
            ModelState.Remove("Image");
            ModelState.Remove("PropertyAmenity");
            ModelState.Remove("Wishlist");
            ModelState.Remove("Requests");
            ModelState.Remove("Reviews");
            ModelState.Remove("Messages");

            if (IsOwner)
                property.OwnerID = SessionUserID!;

            var ownerExists = await _context.User.AnyAsync(u => u.ID == property.OwnerID);
            if (!ownerExists)
                ModelState.AddModelError("OwnerID", "Selected owner does not exist.");

            if (property.AvailableRooms > property.BedRooms)
                ModelState.AddModelError("AvailableRooms", "Available rooms cannot exceed total bedrooms.");

            if (ModelState.IsValid)
            {
                property.ID = Guid.NewGuid().ToString();
                property.CreatedAt = DateTime.Now;
                property.Status = PropertyStatus.Available;

                _context.Add(property);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Property listed successfully!";
                return RedirectToAction(nameof(Index));
            }

            if (IsOwner)
                ViewBag.OwnerID = SessionUserID;
            else
                ViewData["OwnerID"] = new SelectList(
                    _context.User.Where(u => u.Role == UserRole.Owner), "ID", "Name", property.OwnerID);

            return View(property);
        }

        // ── EDIT (Owner of property / Admin only) ─────────
        public async Task<IActionResult> Edit(string? id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (id == null) return NotFound();

            var property = await _context.Property.FindAsync(id);
            if (property == null) return NotFound();

            if (IsOwner && property.OwnerID != SessionUserID)
            {
                TempData["Error"] = "You can only edit your own properties.";
                return RedirectToAction(nameof(Index));
            }
            if (IsTenant)
            {
                TempData["Error"] = "Tenants cannot edit properties.";
                return RedirectToAction(nameof(Index));
            }

            if (IsAdmin)
                ViewData["OwnerID"] = new SelectList(
                    _context.User.Where(u => u.Role == UserRole.Owner), "ID", "Name", property.OwnerID);

            return View(property);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Property property)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (IsTenant) return Forbid();
            if (id != property.ID) return NotFound();

            ModelState.Remove("Owner");
            ModelState.Remove("Image");
            ModelState.Remove("PropertyAmenity");
            ModelState.Remove("Wishlist");
            ModelState.Remove("Requests");
            ModelState.Remove("Reviews");
            ModelState.Remove("Messages");

            var existing = await _context.Property.AsNoTracking().FirstOrDefaultAsync(p => p.ID == id);
            if (existing == null) return NotFound();

            if (IsOwner)
            {
                if (existing.OwnerID != SessionUserID)
                {
                    TempData["Error"] = "You can only edit your own properties.";
                    return RedirectToAction(nameof(Index));
                }
                property.OwnerID = existing.OwnerID;
            }

            if (property.AvailableRooms > property.BedRooms)
                ModelState.AddModelError("AvailableRooms", "Available rooms cannot exceed total bedrooms.");

            if (ModelState.IsValid)
            {
                try
                {
                    property.CreatedAt = existing.CreatedAt;
                    _context.Update(property);
                    await _context.SaveChangesAsync();
                    TempData["Success"] = "Property updated successfully.";
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Property.Any(e => e.ID == id)) return NotFound();
                    throw;
                }
            }

            if (IsAdmin)
                ViewData["OwnerID"] = new SelectList(
                    _context.User.Where(u => u.Role == UserRole.Owner), "ID", "Name", property.OwnerID);

            return View(property);
        }

        // ── DELETE (Owner of property / Admin only) ───────
        public async Task<IActionResult> Delete(string? id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (id == null) return NotFound();

            var property = await _context.Property
                .Include(p => p.Owner)
                .FirstOrDefaultAsync(p => p.ID == id);

            if (property == null) return NotFound();

            if (IsOwner && property.OwnerID != SessionUserID)
            {
                TempData["Error"] = "You can only delete your own properties.";
                return RedirectToAction(nameof(Index));
            }
            if (IsTenant)
            {
                TempData["Error"] = "Tenants cannot delete properties.";
                return RedirectToAction(nameof(Index));
            }

            return View(property);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (IsTenant) return Forbid();

            var property = await _context.Property
                .Include(p => p.PropertyAmenity)
                .Include(p => p.Image)
                .FirstOrDefaultAsync(p => p.ID == id);

            if (property != null)
            {
                if (IsOwner && property.OwnerID != SessionUserID)
                {
                    TempData["Error"] = "You can only delete your own properties.";
                    return RedirectToAction(nameof(Index));
                }

                _context.PropertyAmenity.RemoveRange(property.PropertyAmenity);
                _context.PropertyImage.RemoveRange(property.Image);
                _context.Property.Remove(property);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Property deleted.";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}