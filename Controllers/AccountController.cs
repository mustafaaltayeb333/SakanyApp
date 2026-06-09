using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;
using Sakany.Services;

namespace Sakany.Controllers
{
    public class AccountController : Controller
    {
        private readonly SakanyDbContext _context;
        private readonly PasswordHasher _passwordHasher;

        public AccountController(SakanyDbContext context)
        {
            _context = context;
            _passwordHasher = new PasswordHasher();
        }

        // ── LOGIN GET ─────────────────────────────────────
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserID") != null)
                return RedirectToAction("Index", "Home");
            return View();
        }

        // ── LOGIN POST ────────────────────────────────────
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ModelState.AddModelError("", "Email and password are required.");
                return View();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower());

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid email or password.");
                return View();
            }

            // SECURE: Verify hashed password instead of plain-text comparison
            bool isValid = _passwordHasher.VerifyPassword(user, user.Password, password);

            if (!isValid)
            {
                ModelState.AddModelError("", "Invalid email or password.");
                return View();
            }

            // Rehash if needed (algorithm upgrade path)
            if (_passwordHasher.NeedsRehash(user, user.Password, password))
            {
                user.Password = _passwordHasher.HashPassword(user, password);
                _context.Update(user);
                await _context.SaveChangesAsync();
            }

            // Establish session
            HttpContext.Session.SetString("UserID", user.ID);
            HttpContext.Session.SetString("UserRole", user.Role.ToString());
            HttpContext.Session.SetString("UserName", user.Name);
			HttpContext.Session.SetString("UserEmail", user.Email);

            TempData["Success"] = $"Welcome back, {user.Name}!";
            return RedirectToAction("Index", "Home");
        }

        // ── REGISTER GET ──────────────────────────────────
        public IActionResult Register()
        {
            if (HttpContext.Session.GetString("UserID") != null)
                return RedirectToAction("Index", "Home");
            return View();
        }

        // ── REGISTER POST ─────────────────────────────────
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("Name,Email,Password,Phone,Role")] User user)
        {
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
                ModelState.AddModelError("Phone", "An account with this phone number already exists.");
            }

            if (ModelState.IsValid)
            {
                user.ID = Guid.NewGuid().ToString();
                
                // SECURE: Hash password before storage
                user.Password = _passwordHasher.HashPassword(user, user.Password);

                _context.Add(user);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Registration successful! Please log in.";
                return RedirectToAction(nameof(Login));
            }

            return View(user);
        }

        // ── LOGOUT ────────────────────────────────────────
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            TempData["Success"] = "You have been logged out successfully.";
            return RedirectToAction("Index", "Home");
        }

        // ── PROFILE ───────────────────────────────────────
        public async Task<IActionResult> Profile()
        {
            var userId = HttpContext.Session.GetString("UserID");
            if (string.IsNullOrEmpty(userId))
                return RedirectToAction(nameof(Login));

            var user = await _context.User.FindAsync(userId);
            if (user == null) return NotFound();

            return View(user);
        }

        // ── EDIT PROFILE GET ──────────────────────────────
        public async Task<IActionResult> EditProfile()
        {
            var userId = HttpContext.Session.GetString("UserID");
            if (string.IsNullOrEmpty(userId))
                return RedirectToAction(nameof(Login));

            var user = await _context.User.FindAsync(userId);
            if (user == null) return NotFound();

            // Don't send password hash to view
            user.Password = string.Empty;
            return View(user);
        }

        // ── EDIT PROFILE POST ─────────────────────────────
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile([Bind("ID,Name,Email,Phone")] User updatedUser, string? currentPassword, string? newPassword, string? confirmPassword)
        {
            var userId = HttpContext.Session.GetString("UserID");
            if (string.IsNullOrEmpty(userId) || userId != updatedUser.ID)
                return RedirectToAction(nameof(Login));

            var user = await _context.User.FindAsync(userId);
            if (user == null) return NotFound();

            // Check email uniqueness (excluding self)
            var emailExists = await _context.User
                .AnyAsync(u => u.Email.ToLower() == updatedUser.Email.ToLower() && u.ID != userId);
            if (emailExists)
            {
                ModelState.AddModelError("Email", "This email is already in use.");
            }

            // Check phone uniqueness (excluding self)
            var phoneExists = await _context.User
                .AnyAsync(u => u.Phone == updatedUser.Phone && u.ID != userId);
            if (phoneExists)
            {
                ModelState.AddModelError("Phone", "This phone number is already in use.");
            }

            // Password change logic
            if (!string.IsNullOrWhiteSpace(newPassword))
            {
                if (string.IsNullOrWhiteSpace(currentPassword))
                {
                    ModelState.AddModelError("currentPassword", "Current password is required to set a new password.");
                }
                else if (!_passwordHasher.VerifyPassword(user, user.Password, currentPassword))
                {
                    ModelState.AddModelError("currentPassword", "Current password is incorrect.");
                }
                else if (newPassword != confirmPassword)
                {
                    ModelState.AddModelError("confirmPassword", "New passwords do not match.");
                }
                else if (newPassword.Length < 6)
                {
                    ModelState.AddModelError("newPassword", "Password must be at least 6 characters.");
                }
                else
                {
                    // SECURE: Hash new password
                    user.Password = _passwordHasher.HashPassword(user, newPassword);
                }
            }

            if (ModelState.IsValid)
            {
                user.Name = updatedUser.Name;
                user.Email = updatedUser.Email;
                user.Phone = updatedUser.Phone;

                _context.Update(user);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Profile updated successfully.";
                return RedirectToAction(nameof(Profile));
            }

            // Repopulate for view
            updatedUser.Password = string.Empty;
            return View(updatedUser);
        }
    }
}