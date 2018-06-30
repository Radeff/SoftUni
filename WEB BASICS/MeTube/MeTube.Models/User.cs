using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MeTube.Models
{
    public class User
    {
        public User()
        {
            this.Tubes = new List<Tube>();
        }

        public int Id { get; set; }

        [Required]        
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        public IList<Tube> Tubes { get; set; }
    }
}
