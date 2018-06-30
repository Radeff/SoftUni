using Kittens.Data;
using SimpleMvc.Framework.Controllers;
using SimpleMvc.Framework.Interfaces;

namespace Kittens.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected BaseController()
        {
            this.Context = new KittensDbContext();
        }

        protected KittensDbContext Context { get; set; }

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
	                <a class=""nav-link"" href=""/kittens/all"">All Kittens</a>
                    </li>
                    <li class=""nav-item active"">
	                    <a class=""nav-link"" href=""/kittens/add"">Add Kitten</a>
                    </li>
                    <li class=""nav-item active"">
	                    <a class=""nav-link"" href=""/users/logout"">Logout</a>
                    </li>";
            }
            else
            {
                this.Model.Data["menu"] =                    
                    @"<li class=""nav-item active"">
	                    <a class=""nav-link"" href=""/users/login"">Login</a>
                    </li>
                    <li class=""nav-item active"">
	                    <a class=""nav-link"" href=""/users/register"">Register</a>
                    </li>";
            }
        }
    }
}
