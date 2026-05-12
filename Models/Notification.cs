using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakany.Models
{
    public class Notification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string UserID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        public bool IsRead { get; set; }
         
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation Properties

        //  1 to Many Rel.
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}
