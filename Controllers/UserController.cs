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

        public UserController(SakanyDbContext context)
        {
            _context = context;
        }

        // ── Auth helpers ─────────────────────────────────────────
        private string? SessionUserID   => HttpContext.Session.GetString("UserID");
        private string? SessionRole     => HttpContext.Session.GetString("UserRole");
        private bool    IsLoggedIn      => SessionUserID != null;
        private bool    IsAdmin         => SessionRole == "Admin";

        private IActionResult DenyAccess()
        {
            TempData["Error"] = "Access denied. Admins only.";
            return RedirectToAction("Index", "Home");
        }

        // ── GET: User/Index ──────────────────────────────────────
        public async Task<IActionResult> Index()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin)    return DenyAccess();

            return View(await _context.User.OrderBy(u => u.Name).ToListAsync());
        }

        // ── GET: User/Details/id ─────────────────────────────────
        public async Task<IActionResult> Details(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin)    return DenyAccess();

            if (id == null) return NotFound();

            var user = await _context.User.FirstOrDefaultAsync(m => m.ID == id);
            if (user == null) return NotFound();

            return View(user);
        }

        // ── GET: User/Create ─────────────────────────────────────
        public IActionResult Create()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin)    return DenyAccess();

            return View();
        }

        // ── POST: User/Create ────────────────────────────────────
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Email,Password,Phone,Role")] User user)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin)    return DenyAccess();

            // Remove ID from validation — we assign it
            ModelState.Remove("ID");

            // Check for duplicate email
            if (await _context.User.AnyAsync(u => u.Email == user.Email.Trim().ToLower()))
                ModelState.AddModelError("Email", "An account with this email already exists.");

            if (ModelState.IsValid)
            {
                user.ID       = Guid.NewGuid().ToString();
                user.Email    = user.Email.Trim().ToLower();
                user.Password = PasswordHasher.Hash(user.Password);   // ← hash before saving

                _context.Add(user);
                await _context.SaveChangesAsync();

                TempData["Success"] = $"User '{user.Name}' created.";
                return RedirectToAction(nameof(Index));
            }

            return View(user);
        }

        // ── GET: User/Edit/id ────────────────────────────────────
        public async Task<IActionResult> Edit(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin)    return DenyAccess();

            if (id == null) return NotFound();

            var user = await _context.User.FindAsync(id);
            if (user == null) return NotFound();

            // Don't expose the hash in the form
            ViewBag.HasHashedPassword = user.Password.Contains(':');
            return View(user);
        }

        // ── POST: User/Edit/id ───────────────────────────────────
        /// <summary>
        /// Binds everything except Password — password is handled separately
        /// to avoid accidentally clearing it with an empty field.
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,
            [Bind("ID,Name,Email,Phone,Role")] User user,
            string? newPassword)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin)    return DenyAccess();

            if (id != user.ID) return NotFound();

            // Check for duplicate email (excluding this user)
            if (await _context.User.AnyAsync(u => u.Email == user.Email.Trim().ToLower() && u.ID != id))
                ModelState.AddModelError("Email", "Another account already uses this email.");

            if (!string.IsNullOrWhiteSpace(newPassword) && newPassword.Length < 6)
                ModelState.AddModelError("", "Password must be at least 6 characters.");

            if (ModelState.IsValid)
            {
                try
                {
                    var existing = await _context.User.AsNoTracking().FirstAsync(u => u.ID == id);

                    user.Email    = user.Email.Trim().ToLower();
                    user.Password = string.IsNullOrWhiteSpace(newPassword)
                        ? existing.Password                          // keep existing hash
                        : PasswordHasher.Hash(newPassword);          // new hash

                    _context.Update(user);
                    await _context.SaveChangesAsync();

                    // If the admin just edited themselves, refresh the session role immediately
                    if (id == SessionUserID)
                    {
                        HttpContext.Session.SetString("UserName",  user.Name);
                        HttpContext.Session.SetString("UserRole",  user.Role.ToString());
                        HttpContext.Session.SetString("UserEmail", user.Email);
                    }

                    TempData["Success"] = $"User '{user.Name}' updated.";
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.ID)) return NotFound();
                    throw;
                }
            }

            return View(user);
        }

        // ── GET: User/Delete/id ──────────────────────────────────
        public async Task<IActionResult> Delete(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin)    return DenyAccess();

            if (id == null) return NotFound();

            var user = await _context.User.FirstOrDefaultAsync(m => m.ID == id);
            if (user == null) return NotFound();

            return View(user);
        }

        // ── POST: User/Delete/id ─────────────────────────────────
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin)    return DenyAccess();

            // Prevent self-deletion
            if (id == SessionUserID)
            {
                TempData["Error"] = "You cannot delete your own account.";
                return RedirectToAction(nameof(Index));
            }

            var user = await _context.User.FindAsync(id);
            if (user != null)
            {
                _context.User.Remove(user);
                await _context.SaveChangesAsync();
                TempData["Success"] = $"User '{user.Name}' deleted.";
            }

            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(string id) =>
            _context.User.Any(e => e.ID == id);
    }
}