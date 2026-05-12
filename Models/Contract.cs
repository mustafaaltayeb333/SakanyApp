using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakany.Models
{
    public enum ContractStatus
    {
        Active,
        Expired,
        Canceled
    }
    public class Contract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string RequestID { get; set; }

        [Required]
        public string OwnerID { get; set; }

        [Required]
        public string TenantID { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal Amount { get; set; }

        [Required]
        public ContractStatus Status { get; set; } 

        [Required]
        public string PropertyID { get; set; }

        // Navigation Properties
        [ForeignKey("RequestID")]
        public Request Request { get; set; }

        [ForeignKey("OwnerID")]
        public User Owner { get; set; }

        [ForeignKey("TenantID")]
        public User Tenant { get; set; }

        [ForeignKey("PropertyID")]
        public Property Property { get; set; }
    }
}
