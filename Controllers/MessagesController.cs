using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;

namespace Sakany.Controllers
{
    public class MessagesController : Controller
    {
        private readonly SakanyDbContext _context;
        public MessagesController(SakanyDbContext context) { _context = context; }

        private string? SessionUserID => HttpContext.Session.GetString("UserID");
        private string? SessionUserName => HttpContext.Session.GetString("UserName");
        private bool IsLoggedIn => SessionUserID != null;

        private async Task Notify(string userId, string title, string body)
        {
            _context.Notification.Add(new Notification
            {
                ID = Guid.NewGuid().ToString(),
                UserID = userId,
                Title = title,
                Body = body,
                IsRead = false,
                CreatedAt = DateTime.Now
            });
            await _context.SaveChangesAsync();
        }

        // ── INBOX ─────────────────────────────────────────
        public async Task<IActionResult> Inbox()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            var allMessages = await _context.Message
                .Include(m => m.Property)
                .Include(m => m.Receiver)
                .Include(m => m.Sender)
                .Where(m => m.SenderID == SessionUserID || m.ReceiverID == SessionUserID)
                .OrderByDescending(m => m.Date)
                .ToListAsync();

            var threads = allMessages
                .GroupBy(m => new
                {
                    m.PropertyID,
                    OtherID = m.SenderID == SessionUserID ? m.ReceiverID : m.SenderID
                })
                .Select(g =>
                {
                    var last = g.First();
                    return new
                    {
                        Property = last.Property,
                        OtherUser = last.SenderID == SessionUserID ? last.Receiver : last.Sender,
                        LastMessage = last,
                        UnreadCount = g.Count(m => m.ReceiverID == SessionUserID && !m.IsRead)
                    };
                })
                .ToList<dynamic>();

            ViewBag.Threads = threads;
            return View();
        }

        // ── CONVERSATION ──────────────────────────────────
        public async Task<IActionResult> Conversation(string propertyId, string otherUserId)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            var property = await _context.Property.Include(p => p.Owner).FirstOrDefaultAsync(p => p.ID == propertyId);
            var otherUser = await _context.User.FindAsync(otherUserId);
            if (property == null || otherUser == null) return NotFound();

            // Mark as read
            var unread = await _context.Message
                .Where(m => m.PropertyID == propertyId && m.SenderID == otherUserId &&
                            m.ReceiverID == SessionUserID && !m.IsRead)
                .ToListAsync();
            unread.ForEach(m => m.IsRead = true);
            if (unread.Any()) await _context.SaveChangesAsync();

            var messages = await _context.Message
                .Include(m => m.Sender)
                .Where(m => m.PropertyID == propertyId &&
                            ((m.SenderID == SessionUserID && m.ReceiverID == otherUserId) ||
                             (m.SenderID == otherUserId && m.ReceiverID == SessionUserID)))
                .OrderBy(m => m.Date)
                .ToListAsync();

            ViewBag.Property = property;
            ViewBag.OtherUser = otherUser;
            ViewBag.Messages = messages;

            return View();
        }

        // ── SEND ──────────────────────────────────────────
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Send(string propertyId, string receiverId, string messageText)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            if (string.IsNullOrWhiteSpace(messageText))
            {
                TempData["Error"] = "Message cannot be empty.";
                return RedirectToAction(nameof(Conversation), new { propertyId, otherUserId = receiverId });
            }

            var property = await _context.Property.FirstOrDefaultAsync(p => p.ID == propertyId);
            var receiver = await _context.User.FindAsync(receiverId);
            if (property == null || receiver == null)
            { TempData["Error"] = "Invalid property or recipient."; return RedirectToAction(nameof(Inbox)); }

            _context.Message.Add(new Message
            {
                ID = Guid.NewGuid().ToString(),
                SenderID = SessionUserID!,
                ReceiverID = receiverId,
                PropertyID = propertyId,
                MessageText = messageText.Trim(),
                Date = DateTime.Now,
                IsRead = false
            });
            await _context.SaveChangesAsync();

            var preview = messageText.Length > 60 ? messageText[..60] + "…" : messageText;
            await Notify(receiverId,
                $"💬 New message from {SessionUserName}",
                $"Re: {property.Address} — \"{preview}\"");

            return RedirectToAction(nameof(Conversation), new { propertyId, otherUserId = receiverId });
        }

        // ── START (from Property Details page) ────────────
        public async Task<IActionResult> Start(string propertyId)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");

            var property = await _context.Property.FirstOrDefaultAsync(p => p.ID == propertyId);
            if (property == null) return NotFound();

            if (property.OwnerID == SessionUserID)
            { TempData["Error"] = "You cannot message yourself."; return RedirectToAction("Details", "Property", new { id = propertyId }); }

            return RedirectToAction(nameof(Conversation), new { propertyId, otherUserId = property.OwnerID });
        }

        // ── UNREAD COUNT (JSON) ───────────────────────────
        public async Task<IActionResult> UnreadCount()
        {
            if (!IsLoggedIn) return Json(0);
            var count = await _context.Message.CountAsync(m => m.ReceiverID == SessionUserID && !m.IsRead);
            return Json(count);
        }
    }
}