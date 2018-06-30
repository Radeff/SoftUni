using Microsoft.EntityFrameworkCore;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Interfaces;
using System.Linq;
using System.Text;

namespace MeTube.App.Controllers
{
    public class HomeController : BaseController
    {
        [HttpGet]        
        public IActionResult Index()
        {
            if (!this.User.IsAuthenticated)
            {
                this.Model.Data["content"] =
                @"<div class=""jumbotron"">
                    <p class=""h1 display-3"">Welcome to MeTube&trade;!</p>
                    <p class=""h3"">The simplest, easiest to use, most comfortable Multimedia Application.</p>
                    <hr class=""my-3"">
                    <p><a href=""/users/login"">Login</a> if you have an account or <a href=""/users/register"">Register</a> now and start tubing.</p>
                </div>";
            }
            else
            {
                this.Model.Data["content"] = $@"<div class=""text-center text-info mb-3"">
                                                    <h3>Welcome, {this.User.Name}!</h3>
                                                </div>
                                                <hr class=""my-2""/>";

                var tubes = this.Context.Tubes.Include(t => t.Uploader).ToList();

                if (!tubes.Any())
                {
                    this.Model.Data["tubes"] = @"<div class=""text-center""><p>No videos found.</p></div>";
                }
                else
                {
                    var tubesHtml = new StringBuilder();                    
                    tubesHtml.Append(@"<div class=""row text-center offset-2"">");

                    for (int i = 0; i < tubes.Count; i++)
                    {                        

                        tubesHtml.Append
                            (
                  $@"<div class=""col-3"">
                          <a href=""/tubes/details?id={tubes[i].Id}"">
                             <img class=""img-thumbnail tube-thumbnail"" src=""https://img.youtube.com/vi/{tubes[i].YoutubeId}/0.jpg"" alt=""{tubes[i].Title}"" />
                          </a>
                          <div>
                               <h2>{tubes[i].Title}</h2>
                               <p class=""font-italic"">{tubes[i].Uploader.Username}</p>
                          </div>
                     </div>"
                            );

                        if (i % 3 == 2)
                        {
                            tubesHtml.Append(@"</div><div class=""row text-center offset-2"">");
                        }
                    }

                    tubesHtml.Append(@"</div>");

                    this.Model.Data["tubes"] = tubesHtml.ToString();
                }

            }

            
            return this.View();
        }
    }
}
