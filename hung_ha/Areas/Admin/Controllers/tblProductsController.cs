using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using hung_ha.Models.DbSet;
using hung_ha.Models.DAO;
using hung_ha.helpers;
using System.IO;

namespace hung_ha.Areas.Admin.Controllers
{
    
    public class tblProductsController : BaseController
    {
        private Model1 db = new Model1();

        // GET: Admin/tblProducts
        public ActionResult Index(int page=1,int pageSize = 20, string search = "")
        {
            IEnumerable<tblProduct> tblProducts = Product.findAllPageList(page,pageSize,search);
            ViewBag.Title = "Danh sách sản phẩm";
            ViewBag.Search = search;
            ViewBag.Page = page;
            ViewBag.PageSize = pageSize;
            return View(tblProducts);
        }

        // GET: Admin/tblProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProduct tblProduct = db.tblProducts.Find(id);
            if (tblProduct == null)
            {
                return HttpNotFound();
            }
            return View(tblProduct);
        }

        // GET: Admin/tblProducts/Create
        public ActionResult Create()
        {
            ViewBag.category_id = new SelectList(db.tblProductCategories, "id", "name");
            return View();
        }

        // POST: Admin/tblProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,category_id,description,price,created_at,img,views,sale")] tblProduct tblProduct)
        {
            if (ModelState.IsValid)
            {
                db.tblProducts.Add(tblProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.category_id = new SelectList(db.tblProductCategories, "id", "name", tblProduct.category_id);
            return View(tblProduct);
        }

        // GET: Admin/tblProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProduct tblProduct = db.tblProducts.Find(id);
            if (tblProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.category_id = new SelectList(db.tblProductCategories, "id", "name", tblProduct.category_id);
            return View(tblProduct);
        }

        // POST: Admin/tblProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,category_id,description,price,created_at,img,views,sale")] tblProduct tblProduct,HttpPostedFileBase fileImg)
        {
            if (ModelState.IsValid)
            {
                if(fileImg != null && fileImg.ContentLength > 0)
                {
                    string _path = Path.Combine(Server.MapPath("~/asset/vendor/img/product"), fileImg.FileName);
                    fileImg.SaveAs(_path);
                    tblProduct.img = fileImg.FileName;
                }
                db.Entry(tblProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.category_id = new SelectList(db.tblProductCategories, "id", "name", tblProduct.category_id);
            return View(tblProduct);
        }

        // GET: Admin/tblProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProduct tblProduct = db.tblProducts.Find(id);
            if (tblProduct == null)
            {
                return HttpNotFound();
            }
            return View(tblProduct);
        }

        // POST: Admin/tblProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblProduct tblProduct = db.tblProducts.Find(id);
            db.tblProducts.Remove(tblProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
