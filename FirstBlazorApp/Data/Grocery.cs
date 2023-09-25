using System.ComponentModel.DataAnnotations;

namespace FirstBlazorApp.Data
{
    public class Grocery
    {
        [Required]
        [StringLength(15, ErrorMessage ="Grocery Name should be less than 15 characters")]
        public string Name { get; set; }
        
        [Required]
        [Range(1,1000, ErrorMessage = "The Price of the item should be between 1 and 10000")]
        public float Price { get; set; }
    }
}
