using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Condorcet.Eshop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Info(int id)
        {
            Models.Product product;
            using (Models.Entities entity = new Models.Entities())
            {
                product = entity.Products.FirstOrDefault(p => p.Id == id);
            }
            if (product == null)
            {
                //throw new HttpException(404, "Some description");
                return View("~/Views/Shared/Error.cshtml");
            }
            return View(product);
        }
    }
}