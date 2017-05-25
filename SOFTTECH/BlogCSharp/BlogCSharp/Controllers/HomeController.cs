using System.Web.Mvc;

namespace BlogCSharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("List", "Article");
        }        
    }
}