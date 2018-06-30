using System.ComponentModel.DataAnnotations;

namespace Kittens.Web.Models.BindingModels
{
    public class UserRegisteringModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
