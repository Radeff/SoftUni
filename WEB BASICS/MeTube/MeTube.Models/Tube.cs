using System.ComponentModel.DataAnnotations;

namespace MeTube.Models
{
    public class Tube
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        
        public string Author { get; set; }
        
        public string Description { get; set; }

        [Required]
        public string YoutubeId { get; set; }
        
        public int Views { get; set; }

        [Required]
        public int UploaderId { get; set; }
        
        public User Uploader { get; set; }
    }
}
