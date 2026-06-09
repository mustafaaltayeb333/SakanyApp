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
    public class NotificationsController : Controller
    {
        private readonly SakanyDbContext _context;
		

        public NotificationsController(SakanyDbContext context)
        {
            _context = context;
        }
		
		private string? SessionUserID => HttpContext.Session.GetString("UserID");
        private bool IsLoggedIn => SessionUserID != null;
		
        // GET: Notifications
        public async Task<IActionResult> Index()
        {
			 if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            var notifications = await _context.Notification
                .Where(n => n.UserID == SessionUserID)
                .OrderByDescending(n => n.CreatedAt)
                .ToListAsync();
            return View(notifications);
        }
		
		[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MarkRead(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            var n = await _context.Notification.FirstOrDefaultAsync(x => x.ID == id && x.UserID == SessionUserID);
            if (n != null) { n.IsRead = true; await _context.SaveChangesAsync(); }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MarkAllRead()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            var list = await _context.Notification.Where(n => n.UserID == SessionUserID && !n.IsRead).ToListAsync();
            list.ForEach(n => n.IsRead = true);
            await _context.SaveChangesAsync();
            TempData["Success"] = "All notifications marked as read.";
            return RedirectToAction(nameof(Index));
        }

        // GET: Notifications/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notification = await _context.Notification
                .Include(n => n.User)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (notification == null)
            {
                return NotFound();
            }

            return View(notification);
        }

        // GET: Notifications/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.User, "ID", "Name");
            return View();
        }

        // POST: Notifications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserID,Title,Body,IsRead,CreatedAt")] Notification notification)
        {
            if (ModelState.IsValid)
            {
                _context.Add(notification);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.User, "ID", "Name", notification.UserID);
            return View(notification);
        }

        // GET: Notifications/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notification = await _context.Notification.FindAsync(id);
            if (notification == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.User, "ID", "Name", notification.UserID);
            return View(notification);
        }

        // POST: Notifications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,UserID,Title,Body,IsRead,CreatedAt")] Notification notification)
        {
            if (id != notification.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notification);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotificationExists(notification.ID))
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
            ViewData["UserID"] = new SelectList(_context.User, "ID", "ID", notification.UserID);
            return View(notification);
        }

        // GET: Notifications/Delete/5


        // POST: Notifications/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            var n = await _context.Notification.FirstOrDefaultAsync(x => x.ID == id && x.UserID == SessionUserID);
            if (n != null) { _context.Notification.Remove(n); await _context.SaveChangesAsync(); }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ClearAll()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            var all = await _context.Notification.Where(n => n.UserID == SessionUserID).ToListAsync();
            _context.Notification.RemoveRange(all);
            await _context.SaveChangesAsync();
            TempData["Success"] = "All cleared.";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UnreadCount()
        {
            if (!IsLoggedIn) return Json(0);
            return Json(await _context.Notification.CountAsync(n => n.UserID == SessionUserID && !n.IsRead));
        }
		
        private bool NotificationExists(string id)
        {
            return _context.Notification.Any(e => e.ID == id);
        }
    }
}
