using MeTube.Data;
using SimpleMvc.Framework.Controllers;
using SimpleMvc.Framework.Interfaces;

namespace MeTube.App.Controllers
{
    public class BaseController : Controller
    {
        protected BaseController()
        {
            this.Context = new MeTubeContext();
        }

        protected MeTubeContext Context { get; set; }

        protected IActionResult RedirectToHome()
        {
            return this.RedirectToAction("/home/index");
        }

        public override void OnAuthentication()
        {
            if (this.User.IsAuthenticated)
            {
                this.Model.Data["menu"] =
                    @"<li class=""nav-item active"">
	                <a class=""nav-link h5"" href=""/users/profile"">Profile</a>
                    </li>
                    <li class=""nav-item active"">
	                    <a class=""nav-link h5"" href=""/tubes/upload"">Upload</a>
                    </li>
                    <li class=""nav-item active"">
	                    <a class=""nav-link h5"" href=""/users/logout"">Logout</a>
                    </li>";
            }
            else
            {
                this.Model.Data["tubes"] = string.Empty;
                this.Model.Data["menu"] =
                    @"<li class=""nav-item active"">
	                    <a class=""nav-link h5"" href=""/users/login"">Login</a>
                    </li>
                    <li class=""nav-item active"">
	                    <a class=""nav-link h5"" href=""/users/register"">Register</a>
                    </li>";
            }
        }
    }
}
