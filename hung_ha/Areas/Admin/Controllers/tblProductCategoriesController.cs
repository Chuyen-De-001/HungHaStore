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

namespace hung_ha.Areas.Admin.Controllers
{
    public class tblProductCategoriesController : BaseController
    {
        private Model1 db = new Model1();

        // GET: Admin/tblProductCategories
        public ActionResult Index(int page =1, int pageSize = 20,string search="")
        {
            IEnumerable<tblProductCategory> tblProductCategory = (IEnumerable<tblProductCategory>)Category.findAllPageList(page, pageSize, search);
            ViewBag.Title = "Danh sách loại SP";
            ViewBag.Search = search;
            ViewBag.Page = page;
            ViewBag.PageSize = pageSize;
            return View(tblProductCategory);
            
        }

        // GET: Admin/tblProductCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProductCategory tblProductCategory = db.tblProductCategories.Find(id);
            if (tblProductCategory == null)
            {
                return HttpNotFound();
            }
            return View(tblProductCategory);
        }

        // GET: Admin/tblProductCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/tblProductCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,created_at")] tblProductCategory tblProductCategory)
        {
            if (ModelState.IsValid)
            {
                db.tblProductCategories.Add(tblProductCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblProductCategory);
        }

        // GET: Admin/tblProductCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProductCategory tblProductCategory = db.tblProductCategories.Find(id);
            if (tblProductCategory == null)
            {
                return HttpNotFound();
            }
            return View(tblProductCategory);
        }

        // POST: Admin/tblProductCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,created_at")] tblProductCategory tblProductCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblProductCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblProductCategory);
        }

        // GET: Admin/tblProductCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProductCategory tblProductCategory = db.tblProductCategories.Find(id);
            if (tblProductCategory == null)
            {
                return HttpNotFound();
            }
            return View(tblProductCategory);
        }

        // POST: Admin/tblProductCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblProductCategory tblProductCategory = db.tblProductCategories.Find(id);
            db.tblProductCategories.Remove(tblProductCategory);
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
