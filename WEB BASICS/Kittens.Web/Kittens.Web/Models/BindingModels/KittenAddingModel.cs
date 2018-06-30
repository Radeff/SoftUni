using System.ComponentModel.DataAnnotations;

namespace Kittens.Web.Models.BindingModels
{
    public class KittenAddingModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Breed { get; set; }
    }
}
