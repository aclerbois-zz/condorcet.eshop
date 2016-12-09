using Condorcet.Eshop.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Condorcet.Eshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailService _emailService;

        public HomeController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public ActionResult Index()
        {
            List<Models.Product> products;
            using ( Models.Entities entity = new Models.Entities())
            {
                products = entity.Products.ToList();
            }
            return View(products);
        }

        [HttpPost]
        public ActionResult Email(string email)
        {
            _emailService.SendEmail(email);
            return View();
        }

    }
}