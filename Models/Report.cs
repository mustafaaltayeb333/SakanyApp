using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakany.Models
{
    public enum ReportStatus
    {
        Pending,
        Reviewed,
        Dismissed
    }

    public class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string ReporterID { get; set; }

        [Required]
        public string PropertyID { get; set; }
        

        [Required]
        public string Reason { get; set; }

        public ReportStatus Status { get; set; }
         
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
         // Navigation Properties
        [ForeignKey("ReporterID")]
        public virtual User Reporter { get; set; }

        [ForeignKey("PropertyID")]
        public virtual Property Property { get; set; }
    }
}
