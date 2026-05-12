using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakany.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string ClientID { get; set; }

        [Required]
        public string PropertyID { get; set; }

        [Required]
        public string RequestID { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rate { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        // Navigation Properties
        [ForeignKey("ClientID")]
        public User Client { get; set; }

        [ForeignKey("PropertyID")]
        public Property Property { get; set; }

        [ForeignKey("RequestID")]
        public Request Request { get; set; }
    }
}
