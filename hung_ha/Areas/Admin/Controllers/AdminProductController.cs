using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hung_ha.Models.DbSet;
using hung_ha.Models.DAO;

namespace hung_ha.Areas.Admin.Controllers
{
    public class AdminProductController : Controller
    {
        // GET: Admin/Product
        public ActionResult Index(int page = 1, int pageSize = 15, string search="")
        {
            IEnumerable<tblProduct> model;
            model = Product.findAllPageList(page, pageSize, search);
            ViewBag.Page = page;
            ViewBag.PageSize = pageSize;
            ViewBag.Search = search;
            return View(model);
        }
    }
}