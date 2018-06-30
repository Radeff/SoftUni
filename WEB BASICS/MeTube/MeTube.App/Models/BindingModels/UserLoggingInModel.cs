using System.ComponentModel.DataAnnotations;

namespace MeTube.App.Models.BindingModels
{
    public class UserLoggingInModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
