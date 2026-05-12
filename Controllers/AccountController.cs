using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;

namespace Sakany.Controllers
{
    public class AccountController : Controller
    {
        private readonly SakanyDbContext _context;

        public AccountController(SakanyDbContext context)
        {
            _context = context;
        }

        // GET: Account/Login
        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            // Already logged in → redirect
            if (HttpContext.Session.GetString("UserID") != null)
                return RedirectToAction("Index", "Home");

            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string email, string password, string? returnUrl = null)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ModelState.AddModelError("", "Email and password are required.");
                return View();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(u => u.Email == email && u.Password == password);

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid email or password.");
                return View();
            }

            // Store session
            HttpContext.Session.SetString("UserID", user.ID);
            HttpContext.Session.SetString("UserName", user.Name);
            HttpContext.Session.SetString("UserRole", user.Role.ToString());
            HttpContext.Session.SetString("UserEmail", user.Email);

            TempData["Success"] = $"Welcome back, {user.Name}!";

            // Role-based redirect
            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);

            return user.Role switch
            {
                UserRole.Admin => RedirectToAction("Index", "Dashboard"),
                UserRole.Owner => RedirectToAction("Index", "Property"),
                _ => RedirectToAction("Index", "Home")
            };
        }

        // GET: Account/Register
        [HttpGet]
        public IActionResult Register()
        {
            if (HttpContext.Session.GetString("UserID") != null)
                return RedirectToAction("Index", "Home");

            return View();
        }

        // POST: Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(string name, string email, string password,
                                                   string phone, UserRole role)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                ModelState.AddModelError("", "Name, email, and password are required.");
                return View();
            }

            if (password.Length < 6)
            {
                ModelState.AddModelError("", "Password must be at least 6 characters.");
                return View();
            }

            var emailExists = await _context.User.AnyAsync(u => u.Email == email);
            if (emailExists)
            {
                ModelState.AddModelError("", "An account with this email already exists.");
                return View();
            }

            // Prevent registering as Admin through the form
            if (role == UserRole.Admin)
                role = UserRole.Tenant;

            var user = new User
            {
                ID = Guid.NewGuid().ToString(),
                Name = name.Trim(),
                Email = email.Trim().ToLower(),
                Password = password,
                Phone = phone?.Trim() ?? "",
                Role = role
            };

            _context.User.Add(user);
            await _context.SaveChangesAsync();

            // Auto login after register
            HttpContext.Session.SetString("UserID", user.ID);
            HttpContext.Session.SetString("UserName", user.Name);
            HttpContext.Session.SetString("UserRole", user.Role.ToString());
            HttpContext.Session.SetString("UserEmail", user.Email);

            TempData["Success"] = $"Account created successfully! Welcome, {user.Name}!";
            return RedirectToAction("Index", "Home");
        }

        // POST: Account/Logout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            TempData["Success"] = "You have been logged out.";
            return RedirectToAction("Index", "Home");
        }

        // GET: Account/Profile
        public async Task<IActionResult> Profile()
        {
            var userId = HttpContext.Session.GetString("UserID");
            if (userId == null)
                return RedirectToAction("Login");

            var user = await _context.User
                .Include(u => u.OwnedProperties)
                .Include(u => u.ClientRequests)
                    .ThenInclude(r => r.Property)
                .Include(u => u.Reviews)
                .Include(u => u.Wishlists)
                    .ThenInclude(w => w.Property)
                .FirstOrDefaultAsync(u => u.ID == userId);

            if (user == null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login");
            }

            return View(user);
        }

        // GET: Account/EditProfile
        [HttpGet]
        public async Task<IActionResult> EditProfile()
        {
            var userId = HttpContext.Session.GetString("UserID");
            if (userId == null)
                return RedirectToAction("Login");

            var user = await _context.User.FindAsync(userId);
            if (user == null) return RedirectToAction("Login");

            return View(user);
        }

        // POST: Account/EditProfile
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile(string name, string phone, string? newPassword)
        {
            var userId = HttpContext.Session.GetString("UserID");
            if (userId == null)
                return RedirectToAction("Login");

            var user = await _context.User.FindAsync(userId);
            if (user == null) return RedirectToAction("Login");

            if (!string.IsNullOrWhiteSpace(name))
                user.Name = name.Trim();

            if (!string.IsNullOrWhiteSpace(phone))
                user.Phone = phone.Trim();

            if (!string.IsNullOrWhiteSpace(newPassword))
            {
                if (newPassword.Length < 6)
                {
                    ModelState.AddModelError("", "Password must be at least 6 characters.");
                    return View(user);
                }
                user.Password = newPassword;
            }

            _context.Update(user);
            await _context.SaveChangesAsync();

            // Update session name
            HttpContext.Session.SetString("UserName", user.Name);

            TempData["Success"] = "Profile updated successfully.";
            return RedirectToAction("Profile");
        }
    }
}
