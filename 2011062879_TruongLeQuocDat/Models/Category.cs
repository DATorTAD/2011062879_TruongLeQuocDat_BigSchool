using System.ComponentModel.DataAnnotations;

namespace _2011062879_TruongLeQuocDat.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}