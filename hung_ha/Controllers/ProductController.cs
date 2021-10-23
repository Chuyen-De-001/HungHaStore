using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hung_ha.Models.DAO;
using hung_ha.Models.DbSet;
using System.Web.Mvc;
using hung_ha.helpers;

namespace hung_ha.Controllers
{
    public class ProductController:Controller
    {
        // GET: Product
        public ActionResult Index(string search = "", int page = 1, int pageSize = 15, string category_id = "")
        {

            var listCategory = Category.findAll();
            ViewBag.ListCategory = listCategory;
            IEnumerable<tblProduct> model;
            string[] breadcrumb = {"Sản phẩm"};
            ViewBag.Breadcrumb = breadcrumb;
            model = Product.findAllPageList(page, pageSize, search,category_id);
            ViewBag.PageSize = pageSize;
            ViewBag.Search = search;
            ViewBag.CategoryId = category_id;
            return View(model);
        }

        public ActionResult View(int id)
        {
            try
            {
                var model = Product.findOne(id);
                string[] breadcrumb = { "Sản phẩm", "Chi tiết sản phẩm", model.name };
                var listProductReleted = Product.findByCategory(model.category_id);
                ViewBag.ProductReleted = listProductReleted;
                ViewBag.Breadcrumb = breadcrumb;
                return View(model);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}