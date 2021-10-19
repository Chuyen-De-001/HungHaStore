using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using hung_ha.Models.DAO;
using hung_ha.Models.DbSet;
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

        public ActionResult ViewCart()
        {
            var model = CartHelper.list();
            string[] breadcrumb = { "Giỏ hàng", "Dánh sách"};
            ViewBag.Breadcrumb = breadcrumb;
            return View(model);
        }

        public ActionResult Quantity(int id,int quantity)
        {
            var currency = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string json = "{\"status\":{{status}},\"total\":\"{{total}}\",\"totalCart\":\"{{totalCart}}\"}";
            List<cart> list = CartHelper.list();
            cart model = CartHelper.findOne(id);
            if(model == null)
            {
                return Content(json.Replace("{{status}}","false"));
            }
            model.quantity = quantity;
            model.total = model.quantity * model.price;
            CartHelper.updateOne(model, list);
            CartHelper.setList(list);
            json = json.Replace("{{status}}", "true");
            json = json.Replace("{{total}}", @String.Format(currency, "{0:c0}", model.total));
            json = json.Replace("{{totalCart}}", @String.Format(currency, "{0:c0}", CartHelper.sum()));
            return Content(json);
        }

        public ActionResult RemoveOne(int id)
        {
            List<cart> list = CartHelper.list();
            cart model = CartHelper.findOne(id);
            if(model == null || list == null)
            {
                return Content("false");
            }
            list.Remove(model);
            return Content("true");

        }
    }
}