using System.ComponentModel.DataAnnotations;

namespace Kittens.Models
{
    public class Kitten
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        public int BreedId { get; set; }

        [Required]
        public Breed Breed { get; set; }
    }
}
