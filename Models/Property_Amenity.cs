using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakany.Models
{
    public class Property_Amenity
    {
        [Required]
        public string PropertyID { get; set; } 
    
        [Required]
        public string AmenityID { get; set; }

         // Navigation Properties
        [ForeignKey("PropertyID")]
        public virtual Property Property { get; set; }

        [ForeignKey("AmenityID")]
        public virtual Amenity Amenity { get; set; }
        
    }
}
