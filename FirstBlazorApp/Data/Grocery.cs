using System.ComponentModel.DataAnnotations;

namespace FirstBlazorApp.Data
{
    public class Grocery
    {
        [Required]
        [StringLength(15,"Grocery Name should be less than 15 characters")];
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
