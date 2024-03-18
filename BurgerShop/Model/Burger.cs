using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BurgerShop.Model
{
    public class Burger
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int UniqueBurgerId { get; set; }

        [Required]

        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]

        [StringLength(60, MinimumLength = 3)]
        public string Description { get; set; }


        [Required] 

        public int Price { get; set; }

        [Required]

        public bool Vegetarian { get; set; }

        [Required]

        public bool Vegan { get; set; }
        [Required]

        public string ImageURL { get; set; }
    }
}
