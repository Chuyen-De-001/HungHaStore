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
        public ActionResult Index(string search = "", int page = 1, int pageSize = 30, int category_id = 0,int ajax = 0)
        {
            List<tblProduct> model;
            if(search != "")
            {
                model = Product.findByPaging(page, pageSize, search);
                ViewBag.TotalElemet= (int)Product.totalElement(search);
            }
            else
            {
                model = Product.findByPaging(page, pageSize, search);
                ViewBag.TotalElemet = (int)Product.totalElement();
            }

            ViewBag.Page = (int)page;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalPage = PagingHelper.getPageCount(ViewBag.TotalElemet, ViewBag.PageSize);
            ViewBag.Search = search;
            return View(model);
        }

        public ActionResult List(int page = 1, int pageSize = 12)
        {
            var model = Product.findAllPageList(page, pageSize);
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