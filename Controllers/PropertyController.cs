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
        private readonly IWebHostEnvironment _env;

        public PropertyController(SakanyDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        private string? SessionUserID => HttpContext.Session.GetString("UserID");
        private string? SessionRole => HttpContext.Session.GetString("UserRole");
        private bool IsLoggedIn => SessionUserID != null;
        private bool IsAdmin => SessionRole == "Admin";
        private bool IsOwner => SessionRole == "Owner";
        private bool IsTenant => SessionRole == "Tenant";

        private async Task SendNotification(string userId, string title, string body)
        {
            _context.Notification.Add(new Notification
            {
                ID = Guid.NewGuid().ToString(),
                UserID = userId,
                Title = title,
                Body = body,
                IsRead = false,
                CreatedAt = DateTime.Now
            });
            await _context.SaveChangesAsync();
        }

        private void BuildDropdowns(Property? p = null)
        {
            ViewBag.TypeList = Enum.GetValues(typeof(PropertyType))
                .Cast<PropertyType>()
                .Select(t => new SelectListItem
                {
                    Value = t.ToString(),
                    Text = t.ToString(),
                    Selected = p != null && p.Type == t
                }).ToList();

            ViewBag.StatusList = Enum.GetValues(typeof(PropertyStatus))
                .Cast<PropertyStatus>()
                .Select(s => new SelectListItem
                {
                    Value = s.ToString(),
                    Text = s.ToString(),
                    Selected = p != null && p.Status == s
                }).ToList();
        }

        private async Task<string?> SaveImageFile(IFormFile file, string propertyId)
        {
            try
            {
                var allowed = new[] { ".jpg", ".jpeg", ".png", ".webp", ".gif" };
                var ext = Path.GetExtension(file.FileName).ToLowerInvariant();
                if (!allowed.Contains(ext)) return null;

                var folder = Path.Combine(_env.WebRootPath, "uploads", "properties");
                Directory.CreateDirectory(folder);

                var fileName = $"{propertyId}_{Guid.NewGuid()}{ext}";
                using var stream = new FileStream(Path.Combine(folder, fileName), FileMode.Create);
                await file.CopyToAsync(stream);
                return $"/uploads/properties/{fileName}";
            }
            catch { return null; }
        }

        private async Task SaveImages(
            string propertyId,
            IFormFile? mainFile, string? mainUrl,
            List<IFormFile>? extraFiles, List<string>? extraUrls)
        {
            var urls = new List<string>();

            if (mainFile?.Length > 0)
            {
                var s = await SaveImageFile(mainFile, propertyId);
                if (s != null) urls.Add(s);
            }
            if (!string.IsNullOrWhiteSpace(mainUrl)) urls.Add(mainUrl.Trim());

            if (extraFiles != null)
                foreach (var f in extraFiles.Where(f => f.Length > 0))
                {
                    var s = await SaveImageFile(f, propertyId);
                    if (s != null) urls.Add(s);
                }

            if (extraUrls != null)
                foreach (var u in extraUrls.Where(u => !string.IsNullOrWhiteSpace(u)))
                    urls.Add(u.Trim());

            foreach (var url in urls)
                _context.PropertyImage.Add(new PropertyImage
                {
                    ID = Guid.NewGuid().ToString(),
                    PropertyID = propertyId,
                    ImageURL = url,
                    UploadDate = DateTime.Now
                });

            if (urls.Any()) await _context.SaveChangesAsync();
        }

        // ═══════════════════════════════════════════════════
        // INDEX
        // ═══════════════════════════════════════════════════
        public async Task<IActionResult> Index(string? city, string? type, string? status,
                                               decimal? minPrice, decimal? maxPrice, string? sortBy,
                                               int pageNumber = 1)
        {
            int pageSize = 9;

            var query = _context.Property
                .Include(p => p.Owner)
                .Include(p => p.Image)
                .Include(p => p.PropertyAmenity).ThenInclude(pa => pa.Amenity)
                .AsQueryable();

            if (IsOwner && !IsAdmin)
                query = query.Where(p => p.OwnerID == SessionUserID);

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

            query = sortBy?.ToLowerInvariant() switch
            {
                "price_asc" => query.OrderBy(p => p.Price),
                "price_desc" => query.OrderByDescending(p => p.Price),
                "recent" => query.OrderByDescending(p => p.CreatedAt),
                _ => query.OrderByDescending(p => p.CreatedAt)
            };

            var paginatedResult = await PaginatedList<Property>.CreateAsync(query, pageNumber, pageSize);

            ViewBag.CurrentPage = paginatedResult.PageIndex;
            ViewBag.TotalPages = paginatedResult.TotalPages;
            ViewBag.TotalCount = paginatedResult.TotalCount;

            ViewBag.Cities = await _context.Property.Select(p => p.City).Distinct().OrderBy(c => c).ToListAsync();
            ViewBag.Types = Enum.GetNames(typeof(PropertyType));
            ViewBag.Statuses = Enum.GetNames(typeof(PropertyStatus));

            ViewBag.CurrentCity = city;
            ViewBag.CurrentType = type;
            ViewBag.CurrentStatus = status;
            ViewBag.CurrentMinPrice = minPrice;
            ViewBag.CurrentMaxPrice = maxPrice;
            ViewBag.CurrentSort = sortBy ?? "recent";

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

            return View(paginatedResult.Items);
        }

        // ═══════════════════════════════════════════════════
        // DETAILS
        // ═══════════════════════════════════════════════════
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

        // ═══════════════════════════════════════════════════
        // CREATE GET
        // ═══════════════════════════════════════════════════
        public IActionResult Create()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (IsTenant) { TempData["Error"] = "Only owners can list properties."; return RedirectToAction(nameof(Index)); }

            BuildDropdowns();

            if (IsAdmin)
                ViewData["OwnerID"] = new SelectList(
                    _context.User.Where(u => u.Role == UserRole.Owner), "ID", "Name");
            else
                ViewBag.OwnerID = SessionUserID; // ✅ FIX

            return View(new Property { Status = PropertyStatus.Available, Type = PropertyType.Apartment });
        }

        // ═══════════════════════════════════════════════════
        // CREATE POST
        // ═══════════════════════════════════════════════════
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            Property property,
            IFormFile? imageFile, string? imageUrl,
            List<IFormFile>? extraImages, List<string>? extraUrls)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (IsTenant) return Forbid();

            ModelState.Remove("Owner"); ModelState.Remove("Image");
            ModelState.Remove("PropertyAmenity"); ModelState.Remove("Wishlist");
            ModelState.Remove("Requests"); ModelState.Remove("Reviews"); ModelState.Remove("Messages");

            if (IsOwner) property.OwnerID = SessionUserID!;

            if (!string.IsNullOrEmpty(property.OwnerID) &&
                !await _context.User.AnyAsync(u => u.ID == property.OwnerID))
                ModelState.AddModelError("OwnerID", "Selected owner does not exist.");

            if (property.AvailableRooms > property.BedRooms)
                ModelState.AddModelError("AvailableRooms", "Available rooms cannot exceed total bedrooms.");

            if (ModelState.IsValid)
            {
                property.ID = Guid.NewGuid().ToString();
                property.CreatedAt = DateTime.Now;
                if (!IsAdmin) property.Status = PropertyStatus.Available;
                if (extraImages != null && extraImages.Count > 4)
                    ModelState.AddModelError("", "You can upload a maximum of 4 extra images.");

                _context.Add(property);
                await _context.SaveChangesAsync();

                await SaveImages(property.ID, imageFile, imageUrl, extraImages, extraUrls);

                TempData["Success"] = "Property listed successfully!";
                return RedirectToAction(nameof(Index));
            }
           
            BuildDropdowns(property);
            if (IsAdmin)
                ViewData["OwnerID"] = new SelectList(
                    _context.User.Where(u => u.Role == UserRole.Owner), "ID", "Name", property.OwnerID);
            else
                ViewBag.OwnerID = SessionUserID; // ✅ FIX

            return View(property);
        }

        // ═══════════════════════════════════════════════════
        // EDIT GET
        // ═══════════════════════════════════════════════════
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

            BuildDropdowns(property);
            if (IsAdmin)
                ViewData["OwnerID"] = new SelectList(
                    _context.User.Where(u => u.Role == UserRole.Owner), "ID", "Name", property.OwnerID);

            return View(property);
        }

        // ═══════════════════════════════════════════════════
        // EDIT POST
        // ═══════════════════════════════════════════════════
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
            string id, Property property,
            IFormFile? imageFile, string? imageUrl,
            List<IFormFile>? extraImages, List<string>? extraUrls,
            List<string>? deleteImageIds)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (IsTenant) return Forbid();
            if (id != property.ID) return NotFound();

            ModelState.Remove("Owner"); ModelState.Remove("Image");
            ModelState.Remove("PropertyAmenity"); ModelState.Remove("Wishlist");
            ModelState.Remove("Requests"); ModelState.Remove("Reviews"); ModelState.Remove("Messages");

            var existing = await _context.Property.AsNoTracking().FirstOrDefaultAsync(p => p.ID == id);
            if (existing == null) return NotFound();

            if (IsOwner && existing.OwnerID != SessionUserID)
            {
                TempData["Error"] = "You can only edit your own properties.";
                return RedirectToAction(nameof(Index));
            }

            if (IsOwner) property.OwnerID = existing.OwnerID;

            if (property.AvailableRooms > property.BedRooms)
                ModelState.AddModelError("AvailableRooms", "Available rooms cannot exceed total bedrooms.");

            if (ModelState.IsValid)
            {
                try
                {
                    property.CreatedAt = existing.CreatedAt;
                    _context.Update(property);
                    await _context.SaveChangesAsync();

                    if (deleteImageIds?.Any() == true)
                    {
                        var toDelete = await _context.PropertyImage
                            .Where(i => deleteImageIds.Contains(i.ID) && i.PropertyID == id)
                            .ToListAsync();
                        _context.PropertyImage.RemoveRange(toDelete);
                        await _context.SaveChangesAsync();
                    }

                    await SaveImages(id, imageFile, imageUrl, extraImages, extraUrls);

                    TempData["Success"] = "Property updated.";
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Property.Any(e => e.ID == id)) return NotFound();
                    throw;
                }
            }

            property.Image = await _context.PropertyImage.Where(i => i.PropertyID == id).ToListAsync();
            BuildDropdowns(property);
            if (IsAdmin)
                ViewData["OwnerID"] = new SelectList(
                    _context.User.Where(u => u.Role == UserRole.Owner), "ID", "Name", property.OwnerID);

            return View(property);
        }

        // ═══════════════════════════════════════════════════
        // DELETE GET
        // ═══════════════════════════════════════════════════
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null) return NotFound();
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (IsTenant) { TempData["Error"] = "Tenants cannot delete properties."; return RedirectToAction(nameof(Index)); }

            var property = await _context.Property.Include(p => p.Owner).FirstOrDefaultAsync(p => p.ID == id);
            if (property == null) return NotFound();

            if (IsOwner && property.OwnerID != SessionUserID)
            {
                TempData["Error"] = "You can only delete your own properties.";
                return RedirectToAction(nameof(Index));
            }

            return View(property);
        }

        // ═══════════════════════════════════════════════════
        // DELETE POST
        // ═══════════════════════════════════════════════════
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
                { TempData["Error"] = "Access denied."; return RedirectToAction(nameof(Index)); }

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