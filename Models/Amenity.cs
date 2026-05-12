using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakany.Models
{
    public class Amenity
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; } =Guid.NewGuid().ToString();
        
        [Required]
        public string Name { get; set; }
        
        public ICollection<Property_Amenity> Property_Amenity { get; set; }
    }
}
