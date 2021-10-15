using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using hung_ha.Models.DAO;
using hung_ha.helpers;
using Newtonsoft.Json;

namespace hung_ha.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add(int id)
        {
            var model = Product.findOne(id);
            var list = CartHelper.Add(model);
            return PartialView(list);
        }

        public ActionResult Count()
        {
            string json = "{\"count\":"+ CartHelper.count() + ",\"toltal\":"+CartHelper.sum()+"}";
            return Content(json);
        }
    }
}