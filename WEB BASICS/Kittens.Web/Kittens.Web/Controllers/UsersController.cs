using Kittens.Models;
using Kittens.Web.Models.BindingModels;
using SimpleMvc.Common;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Attributes.Security;
using SimpleMvc.Framework.Interfaces;
using System.Linq;

namespace Kittens.Web.Controllers
{
    class UsersController : BaseController
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
    }
}
