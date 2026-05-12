using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakany.Models
{
    public enum PropertyType
    {
        Apartment,
        Studio,
        Villa
    }

    public enum PropertyStatus
    {
        Available,
        Rented,
        Sold
    }

    public class Property
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; } = Guid.NewGuid().ToString(); //

        [Required]
        public string OwnerID { get; set; }

        [Required]
        [Range(1, 1000000, ErrorMessage = "Please enter a valid price.")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 10)]
        public string Address { get; set; }

        [Required]
        [Range(0, 50)]
        public int AvailableRooms { get; set; }

        [Required]
        public PropertyType Type { get; set; }

        [Required]
        public PropertyStatus Status { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        [Range(1, 50)]
        public int BedRooms { get; set; }

        [Required]
        [Range(1, 50)]
        public int BathRooms { get; set; }

        [Required]
        [Range(1, 100000)]
        public double Area { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation Properties
        [ForeignKey("OwnerID")]
        public virtual User Owner { get; set; }

        public ICollection<PropertyImage> Image { get; set; }
        public ICollection<Property_Amenity> PropertyAmenity { get; set; }
        public ICollection<Wishlist> Wishlist { get; set; }
        public ICollection<Request> Requests { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}