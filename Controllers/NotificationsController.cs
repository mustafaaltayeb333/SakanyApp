using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;
using Sakany.Services;

namespace Sakany.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly SakanyDbContext _context;
        private readonly INotificationService _notificationService;

        public NotificationsController(SakanyDbContext context, INotificationService notificationService)
        {
            _context = context;
            _notificationService = notificationService;
        }

        private string? SessionUserID => HttpContext.Session.GetString("UserID");
        private bool IsLoggedIn => SessionUserID != null;

        // ── INDEX ─────────────────────────────────────────
        public async Task<IActionResult> Index(bool? unreadOnly = false)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            var query = _context.Notification
                .Where(n => n.UserID == SessionUserID)
                .OrderByDescending(n => n.Priority)
                .ThenByDescending(n => n.CreatedAt)
                .AsQueryable();

            if (unreadOnly == true)
                query = query.Where(n => !n.IsRead);

            ViewBag.UnreadOnly = unreadOnly ?? false;
            ViewBag.UnreadCount = await _notificationService.GetUnreadCountAsync(SessionUserID!);

            return View(await query.ToListAsync());
        }

        // ── DETAILS ───────────────────────────────────────
        public async Task<IActionResult> Details(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (id == null) return NotFound();

            var notification = await _context.Notification
                .FirstOrDefaultAsync(n => n.ID == id && n.UserID == SessionUserID);

            if (notification == null) return NotFound();

            // Auto-mark as read when viewing details
            if (!notification.IsRead)
            {
                await _notificationService.MarkAsReadAsync(id, SessionUserID!);
            }

            return View(notification);
        }

        // ── CREATE (Admin/System only) ────────────────────
        public IActionResult Create()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserID,Title,Body,Priority,ActionUrl,ActionText")] Notification notification)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            ModelState.Remove("ID");
            ModelState.Remove("User");
            ModelState.Remove("CreatedAt");
            ModelState.Remove("IsRead");

            if (ModelState.IsValid)
            {
                notification.ID = Guid.NewGuid().ToString();
                notification.CreatedAt = DateTime.Now;
                notification.IsRead = false;
                notification.NotificationType = "Manual";

                _context.Add(notification);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Notification sent successfully.";
                return RedirectToAction(nameof(Index));
            }

            return View(notification);
        }

        // ── EDIT ──────────────────────────────────────────
        public async Task<IActionResult> Edit(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (id == null) return NotFound();

            var notification = await _context.Notification.FindAsync(id);
            if (notification == null) return NotFound();

            return View(notification);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,UserID,Title,Body,Priority,ActionUrl,ActionText,IsRead")] Notification notification)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (id != notification.ID) return NotFound();

            ModelState.Remove("User");
            ModelState.Remove("CreatedAt");

            if (ModelState.IsValid)
            {
                try
                {
                    var existing = await _context.Notification.FindAsync(id);
                    if (existing == null) return NotFound();

                    existing.Title = notification.Title;
                    existing.Body = notification.Body;
                    existing.Priority = notification.Priority;
                    existing.ActionUrl = notification.ActionUrl;
                    existing.ActionText = notification.ActionText;
                    existing.IsRead = notification.IsRead;
                    if (notification.IsRead && !existing.IsRead)
                        existing.ReadAt = DateTime.Now;

                    _context.Update(existing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotificationExists(notification.ID))
                        return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(notification);
        }

        // ── DELETE ────────────────────────────────────────
        public async Task<IActionResult> Delete(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (id == null) return NotFound();

            var notification = await _context.Notification
                .FirstOrDefaultAsync(n => n.ID == id && n.UserID == SessionUserID);

            if (notification == null) return NotFound();

            return View(notification);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            var notification = await _context.Notification
                .FirstOrDefaultAsync(n => n.ID == id && n.UserID == SessionUserID);

            if (notification != null)
            {
                _context.Notification.Remove(notification);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Notification deleted.";
            }

            return RedirectToAction(nameof(Index));
        }

        // ═══════════════════════════════════════════════════
        // AJAX API ENDPOINTS
        // ═══════════════════════════════════════════════════

        /// <summary>
        /// Mark a notification as read via AJAX.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> MarkAsRead(string id)
        {
            if (!IsLoggedIn) return Unauthorized();

            await _notificationService.MarkAsReadAsync(id, SessionUserID!);
            var unreadCount = await _notificationService.GetUnreadCountAsync(SessionUserID!);

            return Json(new { success = true, unreadCount });
        }

        /// <summary>
        /// Mark all notifications as read via AJAX.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> MarkAllAsRead()
        {
            if (!IsLoggedIn) return Unauthorized();

            await _notificationService.MarkAllAsReadAsync(SessionUserID!);
            return Json(new { success = true, unreadCount = 0 });
        }

        /// <summary>
        /// Get unread count for navbar badge via AJAX.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetUnreadCount()
        {
            if (!IsLoggedIn) return Json(new { count = 0 });

            var count = await _notificationService.GetUnreadCountAsync(SessionUserID!);
            return Json(new { count });
        }

        /// <summary>
        /// Get recent notifications for dropdown via AJAX.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetRecentNotifications(int count = 5)
        {
            if (!IsLoggedIn) return Json(new { notifications = new List<object>() });

            var notifications = await _notificationService.GetRecentAsync(SessionUserID!, count);
			var result = notifications.Select(n => new
			{
				n.ID,
				n.Title,
				n.Body,
				n.IsRead,
				n.Priority,
				n.ActionUrl,
				n.ActionText,
				n.NotificationType,
				TimeAgo = n.TimeAgo,  // ADD THIS
				BadgeClass = n.PriorityBadgeClass,
				PriorityLabel = n.PriorityLabel  // ADD THIS
			});

            return Json(new { notifications = result, unreadCount = notifications.Count(n => !n.IsRead) });
        }

        private bool NotificationExists(string id)
        {
            return _context.Notification.Any(e => e.ID == id);
        }
    }
}