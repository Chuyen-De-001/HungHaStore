﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hung_ha.Models.DAO;
using hung_ha.Models.DbSet;
using System.Web.Mvc;

namespace hung_ha.Controllers
{
    public class ProductController:Controller
    {
        // GET: Product
        public ActionResult Index(string search = "", int page = 1, int pageSize = 9, int category_id = 0)
        {
            List<tblProduct> model;
            if(search != "")
            {
                model = Product.findByPaging(page, pageSize, search);
                ViewBag.Total = (int)Product.totalElement(search);
            }
            else
            {
                model = Product.findByPaging(page, pageSize, search);
                ViewBag.Total = (int)Product.totalElement();
            }
            ViewBag.Page = page;
            ViewBag.PageSize = pageSize;
            ViewBag.Search = search;
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