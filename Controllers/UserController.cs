using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;

namespace Sakany.Controllers
{
    public class UserController : Controller
    {
        private readonly SakanyDbContext _context;

        public UserController(SakanyDbContext context)
        {
            _context = context;
        }

        private string? SessionUserID => HttpContext.Session.GetString("UserID");
        private string? SessionRole => HttpContext.Session.GetString("UserRole");
        private bool IsLoggedIn => SessionUserID != null;
        private bool IsAdmin => SessionRole == "Admin";

        // ── Guard: redirect unauthenticated users ─────────
        private IActionResult? AuthGuard()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin) { TempData["Error"] = "Admin access required."; return RedirectToAction("Index", "Home"); }
            return null;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            var guard = AuthGuard();
            if (guard != null) return guard;

            return View(await _context.User.ToListAsync());
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(string id)
        {
            var guard = AuthGuard();
            if (guard != null) return guard;

            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.ID == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: User/Create
        public IActionResult Create()
        {
            var guard = AuthGuard();
            if (guard != null) return guard;

            ViewBag.RoleList = new SelectList(Enum.GetValues(typeof(UserRole)).Cast<UserRole>().Select(r => new {
                Value = r.ToString(),
                Text = r.ToString()
            }), "Value", "Text");

            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Email,Password,Phone,Role")] User user)
        {
            var guard = AuthGuard();
            if (guard != null) return guard;

            // Prevent creating Admin through the form unless current user is Admin
            if (user.Role == UserRole.Admin && !IsAdmin)
                user.Role = UserRole.Tenant;

            // Generate new ID explicitly
            user.ID = Guid.NewGuid().ToString();

            if (ModelState.IsValid)
            {
                // Check for duplicate email
                var emailExists = await _context.User.AnyAsync(u => u.Email == user.Email);
                if (emailExists)
                {
                    ModelState.AddModelError("Email", "An account with this email already exists.");
                    ViewBag.RoleList = new SelectList(Enum.GetValues(typeof(UserRole)).Cast<UserRole>().Select(r => new {
                        Value = r.ToString(),
                        Text = r.ToString()
                    }), "Value", "Text", user.Role);
                    return View(user);
                }

                _context.Add(user);
                await _context.SaveChangesAsync();
                TempData["Success"] = "User created successfully.";
                return RedirectToAction(nameof(Index));
            }

            ViewBag.RoleList = new SelectList(Enum.GetValues(typeof(UserRole)).Cast<UserRole>().Select(r => new {
                Value = r.ToString(),
                Text = r.ToString()
            }), "Value", "Text", user.Role);

            return View(user);
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            var guard = AuthGuard();
            if (guard != null) return guard;

            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            ViewBag.RoleList = new SelectList(Enum.GetValues(typeof(UserRole)).Cast<UserRole>().Select(r => new {
                Value = r.ToString(),
                Text = r.ToString()
            }), "Value", "Text", user.Role);

            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Name,Email,Phone,Role")] User user, string? newPassword)
        {
            var guard = AuthGuard();
            if (guard != null) return guard;

            if (id != user.ID)
            {
                return NotFound();
            }

            // Prevent changing role to Admin unless current user is Admin
            if (user.Role == UserRole.Admin && !IsAdmin)
                user.Role = UserRole.Tenant;

            ModelState.Remove("Password");
            ModelState.Remove("newPassword");

            if (ModelState.IsValid)
            {
                try
                {
                    var existing = await _context.User.AsNoTracking().FirstOrDefaultAsync(u => u.ID == id);
                    if (existing == null) return NotFound();

                    // Update only allowed fields, keep existing password unless changed
                    existing.Name = user.Name;
                    existing.Email = user.Email;
                    existing.Phone = user.Phone;
                    existing.Role = user.Role;

                    if (!string.IsNullOrWhiteSpace(newPassword))
                    {
                        if (newPassword.Length < 6)
                        {
                            ModelState.AddModelError("", "Password must be at least 6 characters.");
                            ViewBag.RoleList = new SelectList(Enum.GetValues(typeof(UserRole)).Cast<UserRole>().Select(r => new {
                                Value = r.ToString(),
                                Text = r.ToString()
                            }), "Value", "Text", user.Role);
                            return View(user);
                        }
                        existing.Password = newPassword;
                    }

                    _context.Update(existing);
                    await _context.SaveChangesAsync();
                    TempData["Success"] = "User updated successfully.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.RoleList = new SelectList(Enum.GetValues(typeof(UserRole)).Cast<UserRole>().Select(r => new {
                Value = r.ToString(),
                Text = r.ToString()
            }), "Value", "Text", user.Role);

            return View(user);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            var guard = AuthGuard();
            if (guard != null) return guard;

            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.ID == id);
            if (user == null)
            {
                return NotFound();
            }

            // Prevent deleting self
            if (user.ID == SessionUserID)
            {
                TempData["Error"] = "You cannot delete your own account.";
                return RedirectToAction(nameof(Index));
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var guard = AuthGuard();
            if (guard != null) return guard;

            // Prevent deleting self
            if (id == SessionUserID)
            {
                TempData["Error"] = "You cannot delete your own account.";
                return RedirectToAction(nameof(Index));
            }

            var user = await _context.User.FindAsync(id);
            if (user != null)
            {
                // Check for related data before deleting
                var hasProperties = await _context.Property.AnyAsync(p => p.OwnerID == id);
                var hasRequests = await _context.Request.AnyAsync(r => r.ClientID == id);

                if (hasProperties || hasRequests)
                {
                    TempData["Error"] = "Cannot delete user with existing properties or requests. Remove related data first.";
                    return RedirectToAction(nameof(Index));
                }

                _context.User.Remove(user);
                await _context.SaveChangesAsync();
                TempData["Success"] = "User deleted successfully.";
            }

            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(string id)
        {
            return _context.User.Any(e => e.ID == id);
        }
    }
}
