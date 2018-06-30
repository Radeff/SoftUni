
using System.ComponentModel.DataAnnotations;

namespace MeTube.App.Models.BindingModels
{
    public class TubeAddingModel
    {
        [Required]
        public string Title { get; set; }        

        [Required]
        [DataType(DataType.Url)]
        public string YoutubeId { get; set; }

        [Required]
        public int UploaderId { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }               

        
    }
}
