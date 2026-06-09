using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;
using Sakany.Services;

namespace Sakany.Controllers
{
    public class PropertyController : Controller
    {
        private readonly SakanyDbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IWebHostEnvironment _env;

        public PropertyController(SakanyDbContext context, INotificationService notificationService, IWebHostEnvironment env)
        {
            _context = context;
            _notificationService = notificationService;
            _env = env;
        }

        private string? SessionUserID => HttpContext.Session.GetString("UserID");
        private string? SessionRole => HttpContext.Session.GetString("UserRole");
        private bool IsLoggedIn => !string.IsNullOrEmpty(SessionUserID);
        private bool IsAdmin => SessionRole == "Admin";
        private bool IsOwner => SessionRole == "Owner";

        // ═══════════════════════════════════════════════════
        // INDEX — With Owner Filtering & Search
        // ═══════════════════════════════════════════════════
        public async Task<IActionResult> Index(string? city, string? type, string? search, string? viewMode)
        {
            var query = _context.Property
                .Include(p => p.Image)
                .Include(p => p.Owner)
                .Include(p => p.PropertyAmenity)
                .ThenInclude(pa => pa.Amenity)
                .AsQueryable();

            // ── Owner View Mode Filtering ──
            if (IsOwner && viewMode == "mine")
            {
                query = query.Where(p => p.OwnerID == SessionUserID);
                ViewBag.ViewMode = "mine";
                ViewBag.PageTitle = "My Properties";
            }
            else if (IsOwner && viewMode == "others")
            {
                query = query.Where(p => p.OwnerID != SessionUserID && p.Status == PropertyStatus.Available);
                ViewBag.ViewMode = "others";
                ViewBag.PageTitle = "Other Listings";
            }
            else if (IsOwner)
            {
                query = query.Where(p => p.OwnerID != SessionUserID && p.Status == PropertyStatus.Available);
                ViewBag.ViewMode = "others";
                ViewBag.PageTitle = "Browse Listings";
            }
            else if (!IsAdmin)
            {
                query = query.Where(p => p.Status == PropertyStatus.Available);
                ViewBag.ViewMode = "all";
                ViewBag.PageTitle = "Properties";
            }
            else
            {
                ViewBag.ViewMode = "all";
                ViewBag.PageTitle = "All Properties";
            }

            // ── Search Filters ──
            if (!string.IsNullOrWhiteSpace(city))
                query = query.Where(p => p.City == city);
            if (!string.IsNullOrWhiteSpace(type))
                query = query.Where(p => p.Type.ToString() == type);
            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(p => p.Address.Contains(search) || p.City.Contains(search));

            // Dropdown data for filters
            ViewBag.Cities = await _context.Property.Select(p => p.City).Distinct().OrderBy(c => c).ToListAsync();
            ViewBag.Types = Enum.GetNames(typeof(PropertyType)).ToList();

            var list = await query.OrderByDescending(p => p.CreatedAt).ToListAsync();
            return View(list);
        }

        // ═══════════════════════════════════════════════════
        // DETAILS
        // ═══════════════════════════════════════════════════
        public async Task<IActionResult> Details(string id)
        {
            if (id == null) return NotFound();

            var property = await _context.Property
                .Include(p => p.Image)
                .Include(p => p.Owner)
                .Include(p => p.PropertyAmenity)
                .ThenInclude(pa => pa.Amenity)
                .Include(p => p.Reviews)
                .ThenInclude(r => r.Client)
                .FirstOrDefaultAsync(p => p.ID == id);

            if (property == null) return NotFound();

            ViewBag.IsReadOnly = IsOwner && property.OwnerID != SessionUserID;
            ViewBag.CanEdit = IsAdmin || (IsOwner && property.OwnerID == SessionUserID);
            ViewBag.CurrentUserId = SessionUserID;

            return View(property);
        }

        // ═══════════════════════════════════════════════════
        // CREATE GET
        // ═══════════════════════════════════════════════════
        public IActionResult Create()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin && !IsOwner)
            {
                TempData["Error"] = "Only property owners can list properties.";
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Amenities = _context.Amenity.ToList();
            return View();
        }

        // ═══════════════════════════════════════════════════
        // CREATE POST
        // ═══════════════════════════════════════════════════
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Property property, List<IFormFile>? photos, List<string>? selectedAmenities)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin && !IsOwner)
            {
                TempData["Error"] = "Unauthorized.";
                return RedirectToAction(nameof(Index));
            }

            ModelState.Remove("ID");
            ModelState.Remove("Owner");
            ModelState.Remove("Image");
            ModelState.Remove("PropertyAmenity");
            ModelState.Remove("Requests");
            ModelState.Remove("Reviews");
            ModelState.Remove("Contracts");
            ModelState.Remove("Wishlist");
            ModelState.Remove("Messages");

            if (ModelState.IsValid)
            {
                property.ID = Guid.NewGuid().ToString();
                property.OwnerID = SessionUserID!;
                property.CreatedAt = DateTime.Now;

                _context.Add(property);
                await _context.SaveChangesAsync();

                // Save photos
                if (photos != null && photos.Any())
                {
                    await SavePropertyPhotosAsync(property.ID, photos);
                }

                // Save amenities
                if (selectedAmenities != null)
                {
                    foreach (var amenityId in selectedAmenities)
                    {
                        _context.PropertyAmenity.Add(new Property_Amenity
                        {
                            PropertyID = property.ID,
                            AmenityID = amenityId
                        });
                    }
                    await _context.SaveChangesAsync();
                }

                await _notificationService.NotifyAdminsAsync(
                    "New Property Listed",
                    $"Property in {property.City} was just listed.",
                    NotificationPriority.Normal,
                    $"/Property/Details/{property.ID}",
                    "Review");

                TempData["Success"] = "Property created successfully.";
                return RedirectToAction(nameof(Index), new { viewMode = "mine" });
            }

            ViewBag.Amenities = _context.Amenity.ToList();
            return View(property);
        }

        // ═══════════════════════════════════════════════════
        // EDIT GET
        // ═══════════════════════════════════════════════════
        public async Task<IActionResult> Edit(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            var property = await _context.Property
                .Include(p => p.Image)
                .Include(p => p.PropertyAmenity)
                .ThenInclude(pa => pa.Amenity)
                .FirstOrDefaultAsync(p => p.ID == id);

            if (property == null) return NotFound();

            // Security: Only owner or admin can edit
            if (!IsAdmin && property.OwnerID != SessionUserID)
            {
                TempData["Error"] = "You can only edit your own properties.";
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Amenities = _context.Amenity.ToList();
            ViewBag.SelectedAmenityIds = property.PropertyAmenity.Select(pa => pa.AmenityID).ToList();
            return View(property);
        }

        // ═══════════════════════════════════════════════════
        // EDIT POST
        // ═══════════════════════════════════════════════════
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Property property, List<IFormFile>? newPhotos, List<string>? selectedAmenities, List<string>? deletePhotoIds)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (id != property.ID) return NotFound();

            var existing = await _context.Property
                .Include(p => p.Image)
                .Include(p => p.PropertyAmenity)
                .FirstOrDefaultAsync(p => p.ID == id);

            if (existing == null) return NotFound();

            // Security
            if (!IsAdmin && existing.OwnerID != SessionUserID)
            {
                TempData["Error"] = "Unauthorized.";
                return RedirectToAction(nameof(Index));
            }

            ModelState.Remove("Owner");
            ModelState.Remove("Image");
            ModelState.Remove("PropertyAmenity");
            ModelState.Remove("Requests");
            ModelState.Remove("Reviews");
            ModelState.Remove("Contracts");
            ModelState.Remove("Wishlist");
            ModelState.Remove("Messages");

            if (ModelState.IsValid)
            {
                // Update scalar properties
                existing.Price = property.Price;
                existing.Address = property.Address;
                existing.City = property.City;
                existing.Type = property.Type;
                existing.Status = property.Status;
                existing.AvailableRooms = property.AvailableRooms;
                existing.BedRooms = property.BedRooms;
                existing.BathRooms = property.BathRooms;
                existing.Area = property.Area;

                // Delete selected photos
                if (deletePhotoIds != null && deletePhotoIds.Any())
                {
                    foreach (var photoId in deletePhotoIds)
                    {
                        var img = existing.Image.FirstOrDefault(i => i.ID == photoId);
                        if (img != null)
                        {
                            var path = Path.Combine(_env.WebRootPath, img.ImageURL.TrimStart('/'));
                            if (System.IO.File.Exists(path))
                                System.IO.File.Delete(path);

                            _context.PropertyImage.Remove(img);
                        }
                    }
                }

                // Add new photos
                if (newPhotos != null && newPhotos.Any())
                {
                    await SavePropertyPhotosAsync(existing.ID, newPhotos);
                }

                // Update amenities
                var currentAmenityIds = existing.PropertyAmenity.Select(pa => pa.AmenityID).ToList();
                var newAmenityIds = selectedAmenities ?? new List<string>();

                // Remove unselected
                foreach (var pa in existing.PropertyAmenity.Where(pa => !newAmenityIds.Contains(pa.AmenityID)).ToList())
                {
                    _context.PropertyAmenity.Remove(pa);
                }

                // Add new selections
                foreach (var amenityId in newAmenityIds.Where(aid => !currentAmenityIds.Contains(aid)))
                {
                    _context.PropertyAmenity.Add(new Property_Amenity { PropertyID = existing.ID, AmenityID = amenityId });
                }

                _context.Update(existing);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Property updated successfully.";
                return RedirectToAction(nameof(Index), new { viewMode = "mine" });
            }

            ViewBag.Amenities = _context.Amenity.ToList();
            ViewBag.SelectedAmenityIds = existing.PropertyAmenity.Select(pa => pa.AmenityID).ToList();
            return View(property);
        }

        // ═══════════════════════════════════════════════════
        // DELETE GET
        // ═══════════════════════════════════════════════════
        public async Task<IActionResult> Delete(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            var property = await _context.Property
                .Include(p => p.Image)
                .FirstOrDefaultAsync(p => p.ID == id);

            if (property == null) return NotFound();

            if (!IsAdmin && property.OwnerID != SessionUserID)
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

            var property = await _context.Property
                .Include(p => p.Image)
                .FirstOrDefaultAsync(p => p.ID == id);

            if (property == null) return NotFound();

            if (!IsAdmin && property.OwnerID != SessionUserID)
            {
                TempData["Error"] = "Unauthorized.";
                return RedirectToAction(nameof(Index));
            }

            // Delete all physical photo files
            foreach (var img in property.Image)
            {
                var path = Path.Combine(_env.WebRootPath, img.ImageURL.TrimStart('/'));
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);
            }

            _context.Property.Remove(property);
            await _context.SaveChangesAsync();

            TempData["Success"] = "Property deleted successfully.";
            return RedirectToAction(nameof(Index), new { viewMode = "mine" });
        }

        // ═══════════════════════════════════════════════════
        // HELPER: Save Photos
        // ═══════════════════════════════════════════════════
        private async Task SavePropertyPhotosAsync(string propertyId, List<IFormFile> photos)
        {
            var uploadPath = Path.Combine(_env.WebRootPath, "images", "properties");
            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);

            foreach (var photo in photos.Where(p => p.Length > 0))
            {
                var fileName = $"{Guid.NewGuid()}_{Path.GetFileName(photo.FileName)}";
                var filePath = Path.Combine(uploadPath, fileName);
                using var stream = new FileStream(filePath, FileMode.Create);
                await photo.CopyToAsync(stream);

                _context.PropertyImage.Add(new PropertyImage
                {
                    ID = Guid.NewGuid().ToString(),
                    PropertyID = propertyId,
                    ImageURL = $"/images/properties/{fileName}"
                });
            }
            await _context.SaveChangesAsync();
        }

        private bool PropertyExists(string id)
        {
            return _context.Property.Any(e => e.ID == id);
        }
    }
}