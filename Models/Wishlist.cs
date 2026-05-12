using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakany.Models
{
    public class Wishlist
    {
        

        [Required]
        public string UserID { get; set;}

        [Required]
        public string PropertyID { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;

        // Navigation Properties
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        [ForeignKey("PropertyID")]
        public virtual Property Property { get; set; }
    }
}
