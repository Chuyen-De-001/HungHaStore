using hung_ha.Models.DAO;
using System.Web.Mvc;

namespace hung_ha.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = Product.findLimit();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}