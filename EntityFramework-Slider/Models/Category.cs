

using System.ComponentModel.DataAnnotations;

namespace EntityFramework_Slider.Models
{
    public class Category:BaseEntity
    {
        [Required(ErrorMessage = "Don't be empty")]
        [StringLength(20, ErrorMessage = "The name is length must be max 20 character")]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
