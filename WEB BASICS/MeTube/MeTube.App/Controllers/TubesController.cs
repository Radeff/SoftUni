using MeTube.App.Models.BindingModels;
using MeTube.Models;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Attributes.Security;
using SimpleMvc.Framework.Interfaces;
using System.Linq;
using System.Text;

namespace MeTube.App.Controllers
{
    public class TubesController : BaseController
    {
        [HttpGet]
        [PreAuthorize]
        public IActionResult Upload()
        {
            this.Model.Data["error"] = string.Empty;
            return this.View();
        }

        [HttpPost]
        [PreAuthorize]
        public IActionResult Upload(TubeAddingModel model)
        {
            var youTubeId = GetYouTubeIdFromLink(model.YoutubeId);

            if (!this.IsValidModel(model) || youTubeId == null)
            {
                this.Model.Data["error"] = "Tubes must have a Title and a valid YouTube link!";
                return this.View();
            }            

            using (this.Context)
            {               
                var user = this.Context.Users.FirstOrDefault(u => u.Username == this.User.Name);

                var tube = new Tube()
                {
                    Title = model.Title,
                    YoutubeId = youTubeId,
                    UploaderId = user.Id,
                    Author = model.Author,
                    Description = model.Description,
                    Views = 0
                };

                user.Tubes.Add(tube);
                this.Context.Tubes.Add(tube);
                this.Context.SaveChanges();

                return this.RedirectToAction($"/tubes/details?id={tube.Id}");
            }
        }

        [HttpGet]
        [PreAuthorize]
        public IActionResult Details(int id)
        {
            var detailsHtml = new StringBuilder();
            var tube = this.Context.Tubes.Find(id);
            if (tube == null)
            {
                return this.RedirectToHome();
            }

            using (this.Context)
            {   
                tube.Views++;
                this.Context.SaveChanges();
            }

            detailsHtml.Append($@"
                <div class=""text-center"">
                    <h1>{tube.Title}</h1>
                </div>
                <div class=""row"">
                    <div class=""col-6 text-center"">
                        <iframe width=""560"" height=""315"" 
                                src=""https://www.youtube.com/embed/{tube.YoutubeId}"" 
                                frameborder=""0"" allow=""autoplay; encrypted-media"" 
                                allowfullscreen></iframe>
                    </div>
                    <div class=""col-6 text-center"">
                        <h2 class=""text-info"">{tube.Author}</h2>
                        <p class=""text-info"">{tube.Views} View");

            if (tube.Views != 1)
            {
                detailsHtml.Append("s");
            }

            detailsHtml.Append($@"</p>
                        <p>{tube.Description}</p>
                    </div>
                </div>");

            this.Model.Data["details"] = detailsHtml.ToString();
            return this.View();
        }

        private static string GetYouTubeIdFromLink(string youTubeLink)
        {
            string youTubeId = null;
            if (youTubeLink.Contains("youtube.com"))
            {
                youTubeId = youTubeLink.Split("?v=")[1];
            }
            else if (youTubeLink.Contains("youtu.be"))
            {
                youTubeId = youTubeLink.Split("/").Last();
            }

            return youTubeId;
        }
    }
}
