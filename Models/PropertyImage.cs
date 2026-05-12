using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakany.Models
{
    public class PropertyImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string PropertyID { get; set; }
    
        [Required]
        public string ImageURL { get; set; }

        public DateTime UploadDate { get; set; } = DateTime.Now;

        // Navigation Property
        [ForeignKey("PropertyID")]
        public virtual Property Property { get; set; }
    }
}
