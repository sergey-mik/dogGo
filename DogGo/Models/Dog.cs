using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DogGo.Models
{
    public class Dog
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Dog Name")]
        public string Name { get; set; }
        public int OwnerId { get; set; }

        [Required]
        [Display(Name = "Breed")]
        public string Breed { get; set; }

        [MaxLength(100)]
        public string Notes { get; set; }

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }
    }
}