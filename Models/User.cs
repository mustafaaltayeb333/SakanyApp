using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakany.Models
{
    public enum UserRole
    {
        Admin,
        Owner,
        Tenant
    }

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; } = Guid.NewGuid().ToString(); //like 11d3-9a0c-0305e82c3301

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Phone]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        public UserRole Role { get; set; }

        // Navigation Properties
        public ICollection<Property> OwnedProperties { get; set; }
        public ICollection<Wishlist> Wishlists { get; set; }
        public ICollection<Request> ClientRequests { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Message> SentMessages { get; set; }
        public ICollection<Message> ReceivedMessages { get; set; }
        
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Report> Reports { get; set; }
        public ICollection<Contract> OwnerContracts { get; set; }
        public ICollection<Contract> TenantContracts { get; set; }
    }
}