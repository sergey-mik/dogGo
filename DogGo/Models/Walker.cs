using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DogGo.Models
{
    public class Walker
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Walker Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Neighborhood")]
        public int NeighborhoodId { get; set; }

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }
        public Neighborhood Neighborhood { get; set; }
    }
}