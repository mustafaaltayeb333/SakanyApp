using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;

namespace Sakany.Services
{
    /// <summary>
    /// Generic notification utility capable of generating dynamic system alerts
    /// for any business event: status changes, messages, contracts, reports, etc.
    /// </summary>
    public interface INotificationService
    {
        Task NotifyUserAsync(string userId, string title, string body, NotificationPriority priority = NotificationPriority.Normal, string? actionUrl = null, string? actionText = null);
        Task NotifyUsersAsync(IEnumerable<string> userIds, string title, string body, NotificationPriority priority = NotificationPriority.Normal, string? actionUrl = null, string? actionText = null);
        Task NotifyAdminsAsync(string title, string body, NotificationPriority priority = NotificationPriority.Normal, string? actionUrl = null, string? actionText = null);
        Task NotifyPropertyOwnerAsync(string propertyId, string title, string body, NotificationPriority priority = NotificationPriority.Normal, string? actionUrl = null, string? actionText = null);
        Task MarkAsReadAsync(string notificationId, string userId);
        Task MarkAllAsReadAsync(string userId);
        Task<int> GetUnreadCountAsync(string userId);
        Task<List<Notification>> GetRecentAsync(string userId, int count = 10);
    }

    public enum NotificationPriority
    {
        Low = 0,
        Normal = 1,
        High = 2,
        Urgent = 3
    }

    public class NotificationService : INotificationService
    {
        private readonly SakanyDbContext _context;

        public NotificationService(SakanyDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Send a notification to a specific user.
        /// </summary>
        public async Task NotifyUserAsync(string userId, string title, string body, 
            NotificationPriority priority = NotificationPriority.Normal, 
            string? actionUrl = null, string? actionText = null)
        {
            if (string.IsNullOrWhiteSpace(userId)) return;

            var notification = new Notification
            {
                ID = Guid.NewGuid().ToString(),
                UserID = userId,
                Title = title,
                Body = body,
                IsRead = false,
                Priority = (int)priority,
                ActionUrl = actionUrl,
                ActionText = actionText,
                CreatedAt = DateTime.Now,
                NotificationType = "System"
            };

            _context.Notification.Add(notification);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Send a notification to multiple users.
        /// </summary>
        public async Task NotifyUsersAsync(IEnumerable<string> userIds, string title, string body,
            NotificationPriority priority = NotificationPriority.Normal,
            string? actionUrl = null, string? actionText = null)
        {
            var notifications = userIds
                .Where(id => !string.IsNullOrWhiteSpace(id))
                .Distinct()
                .Select(userId => new Notification
                {
                    ID = Guid.NewGuid().ToString(),
                    UserID = userId,
                    Title = title,
                    Body = body,
                    IsRead = false,
                    Priority = (int)priority,
                    ActionUrl = actionUrl,
                    ActionText = actionText,
                    CreatedAt = DateTime.Now,
                    NotificationType = "System"
                })
                .ToList();

            if (notifications.Any())
            {
                _context.Notification.AddRange(notifications);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Send a notification to all admin users.
        /// </summary>
        public async Task NotifyAdminsAsync(string title, string body,
            NotificationPriority priority = NotificationPriority.Normal,
            string? actionUrl = null, string? actionText = null)
        {
            var adminIds = await _context.User
                .Where(u => u.Role == UserRole.Admin)
                .Select(u => u.ID)
                .ToListAsync();

            await NotifyUsersAsync(adminIds, title, body, priority, actionUrl, actionText);
        }

        /// <summary>
        /// Send a notification to the owner of a specific property.
        /// </summary>
        public async Task NotifyPropertyOwnerAsync(string propertyId, string title, string body,
            NotificationPriority priority = NotificationPriority.Normal,
            string? actionUrl = null, string? actionText = null)
        {
            var ownerId = await _context.Property
                .Where(p => p.ID == propertyId)
                .Select(p => p.OwnerID)
                .FirstOrDefaultAsync();

            if (!string.IsNullOrEmpty(ownerId))
            {
                await NotifyUserAsync(ownerId, title, body, priority, actionUrl, actionText);
            }
        }

        /// <summary>
        /// Mark a specific notification as read (with ownership verification).
        /// </summary>
        public async Task MarkAsReadAsync(string notificationId, string userId)
        {
            var notification = await _context.Notification
                .FirstOrDefaultAsync(n => n.ID == notificationId && n.UserID == userId);

            if (notification != null && !notification.IsRead)
            {
                notification.IsRead = true;
                notification.ReadAt = DateTime.Now;
                _context.Update(notification);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Mark all notifications as read for a user.
        /// </summary>
        public async Task MarkAllAsReadAsync(string userId)
        {
            var unreadNotifications = await _context.Notification
                .Where(n => n.UserID == userId && !n.IsRead)
                .ToListAsync();

            foreach (var notification in unreadNotifications)
            {
                notification.IsRead = true;
                notification.ReadAt = DateTime.Now;
            }

            if (unreadNotifications.Any())
            {
                _context.Notification.UpdateRange(unreadNotifications);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Get count of unread notifications for a user.
        /// </summary>
        public async Task<int> GetUnreadCountAsync(string userId)
        {
            return await _context.Notification
                .CountAsync(n => n.UserID == userId && !n.IsRead);
        }

        /// <summary>
        /// Get recent notifications for a user, ordered by priority then date.
        /// </summary>
        public async Task<List<Notification>> GetRecentAsync(string userId, int count = 10)
        {
            return await _context.Notification
                .Where(n => n.UserID == userId)
                .OrderByDescending(n => n.Priority)
                .ThenByDescending(n => n.CreatedAt)
                .Take(count)
                .ToListAsync();
        }
    }
}