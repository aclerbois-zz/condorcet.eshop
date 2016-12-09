using System.Web.Mvc;

namespace Condorcet.Eshop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}