using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakany.Models
{
    public enum RequestStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public class Request
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string ClientID { get; set; }
        
        [Required]
        public string PropertyID { get; set; }

         public DateTime Date { get; set; } = DateTime.Now;

         public RequestStatus Status { get; set; }=RequestStatus.Pending;

         // Navigation Properties
        [ForeignKey("ClientID")]
        public virtual User Client { get; set; }

        [ForeignKey("PropertyID")]
        public virtual Property Property { get; set; }

        public virtual Review? Review { get; set; }

        public virtual Contract? Contract { get; set; }

    }
}
