using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakany.Models
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string  SenderID { get; set; }

        [Required]
        public string  ReceiverID { get; set; }
        
        [Required]
        public string  PropertyID { get; set; }

        [Required]
        public string  MessageText { get; set; }

        public DateTime  Date { get; set; } = DateTime.Now;
        
        public bool IsRead{ get; set; }
        
         // Navigation Properties
        [ForeignKey("SenderID")]
        public User Sender { get; set; }

        [ForeignKey("ReceiverID")]
        public User Receiver { get; set; }

        [ForeignKey("PropertyID")]
        public Property Property { get; set; }
    }
}
