using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hung_ha.Models.DAO;
using System.Web.Mvc;

namespace hung_ha.Controllers
{
    public class ProductController : BaseController
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult View(int id)
        {
            try
            {
                var model = Product.findOne(id);
                var listProductReleted = Product.findByCategory(model.category_id);
                ViewBag.ProductReleted = listProductReleted;
                return View(model);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}