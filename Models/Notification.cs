using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakany.Models
{
    public class Notification
    {
        [Key]
        public string ID { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string UserID { get; set; } = string.Empty;

        [ForeignKey("UserID")]
        public User? User { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Body { get; set; } = string.Empty;

        public bool IsRead { get; set; } = false;

        /// <summary>
        /// Priority level: 0=Low, 1=Normal, 2=High, 3=Urgent
        /// </summary>
        public int Priority { get; set; } = 1;

        /// <summary>
        /// Optional URL to navigate to when clicking the notification.
        /// </summary>
        public string? ActionUrl { get; set; }

        /// <summary>
        /// Optional text for the action button/link.
        /// </summary>
        public string? ActionText { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? ReadAt { get; set; }

        /// <summary>
        /// Category: System, Message, Request, Contract, Report, etc.
        /// </summary>
        public string NotificationType { get; set; } = "System";

        // Computed property for priority badge color
        [NotMapped]
        public string PriorityBadgeClass => Priority switch
        {
            3 => "bg-danger",
            2 => "bg-warning text-dark",
            1 => "bg-info",
            _ => "bg-secondary"
        };

        // Computed property for priority label
        [NotMapped]
        public string PriorityLabel => Priority switch
        {
            3 => "Urgent",
            2 => "High",
            1 => "Normal",
            _ => "Low"
        };

        // Computed property for time ago display
        [NotMapped]
        public string TimeAgo
        {
            get
            {
                var span = DateTime.Now - CreatedAt;
                if (span.TotalMinutes < 1) return "Just now";
                if (span.TotalHours < 1) return $"{(int)span.TotalMinutes}m ago";
                if (span.TotalDays < 1) return $"{(int)span.TotalHours}h ago";
                if (span.TotalDays < 7) return $"{(int)span.TotalDays}d ago";
                return CreatedAt.ToString("MMM dd, yyyy");
            }
        }
    }
}