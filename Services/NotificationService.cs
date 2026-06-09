using Sakany.Data;
using Sakany.Models;

namespace Sakany.Services
{
    public class NotificationService
    {
        private readonly SakanyDbContext _context;

        public NotificationService(SakanyDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(
            string userId,
            string title,
            string body)
        {
            var notification = new Notification
            {
                UserID = userId,
                Title = title,
                Body = body,
                IsRead = false,
                CreatedAt = DateTime.Now
            };

            _context.Notification.Add(notification);
            await _context.SaveChangesAsync();
        }
    }
}