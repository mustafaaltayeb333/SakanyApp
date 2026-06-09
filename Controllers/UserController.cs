using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;
using Sakany.Services;

namespace Sakany.Controllers
{
    public class UserController : Controller
    {
        private readonly SakanyDbContext _context;
        private readonly PasswordHasher _passwordHasher;

        public UserController(SakanyDbContext context)
        {
            _context = context;
            _passwordHasher = new PasswordHasher();
        }

        private string? SessionUserID => HttpContext.Session.GetString("UserID");
        private string? SessionRole => HttpContext.Session.GetString("UserRole");
        private bool IsLoggedIn => SessionUserID != null;
        private bool IsAdmin => SessionRole == "Admin";

        private IActionResult? AdminGuard()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin) { TempData["Error"] = "Only administrators can manage users."; return RedirectToAction("Index", "Home"); }
            return null;
        }

        // ── INDEX ─────────────────────────────────────────
        public async Task<IActionResult> Index()
        {
            var guard = AdminGuard();
            if (guard != null) return guard;

            return View(await _context.User.OrderBy(u => u.Name).ToListAsync());
        }

        // ── DETAILS ───────────────────────────────────────
        public async Task<IActionResult> Details(string id)
        {
            var guard = AdminGuard();
            if (guard != null) return guard;
            if (id == null) return NotFound();

            var user = await _context.User
                .Include(u => u.OwnedProperties)
                .Include(u => u.ClientRequests)
                .Include(u => u.OwnerContracts)
                .Include(u => u.TenantContracts)
                .FirstOrDefaultAsync(u => u.ID == id);

            if (user == null) return NotFound();
            return View(user);
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
        public async Task<IActionResult> Create([Bind("Name,Email,Password,Phone,Role")] User user)
        {
            var guard = AdminGuard();
            if (guard != null) return guard;

            ModelState.Remove("ID");

            // Validate email uniqueness
            var emailExists = await _context.User
                .AnyAsync(u => u.Email.ToLower() == user.Email.ToLower());
            if (emailExists)
            {
                ModelState.AddModelError("Email", "An account with this email already exists.");
            }

            // Validate phone uniqueness
            var phoneExists = await _context.User
                .AnyAsync(u => u.Phone == user.Phone);
            if (phoneExists)
            {
                ModelState.AddModelError("Phone", "This phone number is already in use.");
            }

            if (ModelState.IsValid)
            {
                user.ID = Guid.NewGuid().ToString();
                
                // SECURE: Hash password before storage
                user.Password = _passwordHasher.HashPassword(user, user.Password);

                _context.Add(user);
                await _context.SaveChangesAsync();

                TempData["Success"] = $"User '{user.Name}' created successfully.";
                return RedirectToAction(nameof(Index));
            }

            return View(user);
        }

        // ── EDIT GET ──────────────────────────────────────
        public async Task<IActionResult> Edit(string id)
        {
            var guard = AdminGuard();
            if (guard != null) return guard;
            if (id == null) return NotFound();

            var user = await _context.User.FindAsync(id);
            if (user == null) return NotFound();

            // Don't expose hash to view
            user.Password = string.Empty;
            return View(user);
        }

        // ── EDIT POST ─────────────────────────────────────
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Name,Email,Phone,Role")] User user, string? newPassword)
        {
            var guard = AdminGuard();
            if (guard != null) return guard;
            if (id != user.ID) return NotFound();

            var existingUser = await _context.User.FindAsync(id);
            if (existingUser == null) return NotFound();

            // Check email uniqueness (excluding self)
            var emailExists = await _context.User
                .AnyAsync(u => u.Email.ToLower() == user.Email.ToLower() && u.ID != id);
            if (emailExists)
            {
                ModelState.AddModelError("Email", "This email is already in use.");
            }

            // Check phone uniqueness (excluding self)
            var phoneExists = await _context.User
                .AnyAsync(u => u.Phone == user.Phone && u.ID != id);
            if (phoneExists)
            {
                ModelState.AddModelError("Phone", "This phone number is already in use.");
            }

            // Handle password reset by admin
            if (!string.IsNullOrWhiteSpace(newPassword))
            {
                if (newPassword.Length < 6)
                {
                    ModelState.AddModelError("newPassword", "Password must be at least 6 characters.");
                }
            }

            if (ModelState.IsValid)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                existingUser.Phone = user.Phone;
                existingUser.Role = user.Role;

                // SECURE: Hash new password if provided
                if (!string.IsNullOrWhiteSpace(newPassword))
                {
                    existingUser.Password = _passwordHasher.HashPassword(existingUser, newPassword);
                }

                _context.Update(existingUser);
                await _context.SaveChangesAsync();

                TempData["Success"] = $"User '{existingUser.Name}' updated successfully.";
                return RedirectToAction(nameof(Index));
            }

            user.Password = string.Empty;
            return View(user);
        }

        // ── DELETE GET ────────────────────────────────────
        public async Task<IActionResult> Delete(string id)
        {
            var guard = AdminGuard();
            if (guard != null) return guard;
            if (id == null) return NotFound();

            var user = await _context.User.FindAsync(id);
            if (user == null) return NotFound();

            return View(user);
        }

        // ── DELETE POST ───────────────────────────────────
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var guard = AdminGuard();
            if (guard != null) return guard;

            var user = await _context.User.FindAsync(id);
            if (user != null)
            {
                _context.User.Remove(user);
                await _context.SaveChangesAsync();
                TempData["Success"] = $"User '{user.Name}' deleted successfully.";
            }

            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(string id)
        {
            return _context.User.Any(e => e.ID == id);
        }
    }
}