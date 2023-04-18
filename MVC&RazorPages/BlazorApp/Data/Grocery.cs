
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class Grocery
    {
        [Required]
        [StringLength(15, ErrorMessage = "Name should be less than 15 characters.")]
        public String Name { get; set; }
        [Required]
        [Range(1,15000,ErrorMessage ="Valid Price in between the range of (1-15000)")]
        public float Price { get; set; }
    }
}
