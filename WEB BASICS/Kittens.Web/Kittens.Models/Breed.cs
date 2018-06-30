using System.ComponentModel.DataAnnotations;

namespace Kittens.Models
{
    public class Breed
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
