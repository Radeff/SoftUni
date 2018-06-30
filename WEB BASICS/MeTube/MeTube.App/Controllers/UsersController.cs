using MeTube.App.Models.BindingModels;
using MeTube.Models;
using SimpleMvc.Common;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Attributes.Security;
using SimpleMvc.Framework.Interfaces;
using System.Linq;
using System.Text;

namespace MeTube.App.Controllers
{
    public class UsersController : BaseController
    {
        [HttpGet]
        public IActionResult Register()
        {
            if (this.User.IsAuthenticated)
            {
                return this.RedirectToHome();
            }

            this.Model.Data["error"] = string.Empty;
            return this.View();
        }

        [HttpPost]
        public IActionResult Register(UserRegisteringModel model)
        {
            if (this.User.IsAuthenticated)
            {
                return this.RedirectToHome();
            }

            if (!this.IsValidModel(model))
            {
                this.Model.Data["error"] = "Please, fill all the fields!";
                return this.View();
            }

            var user = new User()
            {
                Username = model.Username,
                Email = model.Email,
                Password = PasswordUtilities.GetPasswordHash(model.Password)
            };

            using (this.Context)
            {
                this.Context.Users.Add(user);
                this.Context.SaveChanges();
                this.SignIn(user.Username, user.Id);
            }

            return this.RedirectToHome();
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (this.User.IsAuthenticated)
            {
                return this.RedirectToHome();
            }

            this.Model.Data["error"] = string.Empty;
            return this.View();
        }

        [HttpPost]
        public IActionResult Login(UserLoggingInModel model)
        {
            if (this.User.IsAuthenticated)
            {
                return this.RedirectToHome();
            }

            var user = this.Context.Users.FirstOrDefault(u => u.Username == model.Username);
            var password = PasswordUtilities.GetPasswordHash(model.Password);

            if (!this.IsValidModel(model) || user == null || password != user.Password)
            {
                this.Model.Data["error"] = "Invalid username or password.";
                return this.View();
            }
            else
            {
                this.SignIn(user.Username, user.Id);
                return this.RedirectToHome();
            }
        }

        [HttpGet]
        [PreAuthorize]
        public IActionResult Logout()
        {
            this.SignOut();
            return this.RedirectToHome();
        }

        [HttpGet]
        [PreAuthorize]
        public IActionResult Profile()
        {   
            using (this.Context)
            {
                var user = this.Context.Users.FirstOrDefault(u => u.Username == this.User.Name);
                var videosHtml = new StringBuilder();

                videosHtml.Append($@"<div class=""text-center text-info mb-3"">
                                    <h2>@{user.Username}</h2>
                                    <h3>({user.Email})</h3>
                                </div>
                                <hr class=""my-2""/>
                                <div class=""row text-center"">");

                var tubes = this.Context.Tubes.Where(t => t.UploaderId == user.Id).ToList();
                if (!tubes.Any())
                {
                    videosHtml.Append(@"</div class=""text-danger""><p>You have not uploaded any videos yet.</p></div>");
                }
                else
                {                    
                    videosHtml.Append($@"
                            <table class=""table"">
                              <thead>
                                <tr>
                                  <th scope=""col"">#</th>
                                  <th scope=""col"">Title</th>
                                  <th scope=""col"">Author</th>
                                  <th scope=""col"">Actions</th>
                                </tr>
                              </thead>
                              <tbody>");
                    for (int i = 0; i < tubes.Count; i++)
                    {
                        var video = tubes[i];
                        videosHtml.Append($@"
                            <tr>
                              <th scope=""row"">{i+1}</th>
                              <td>{video.Title}</td>
                              <td>{video.Author}</td>
                              <td><a href=""/tubes/details?id={video.Id}"">Details</a></td>
                            </tr>");
                    }

                    videosHtml.Append($@"</tbody></table>");
                }

                videosHtml.Append(@"</div>");
                this.Model.Data["videos"] = videosHtml.ToString();
                return this.View();
            }           
        }
    }
}
