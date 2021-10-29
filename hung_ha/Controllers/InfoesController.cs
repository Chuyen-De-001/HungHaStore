using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using hung_ha.Models.DbSet;
using hung_ha.helpers;

namespace hung_ha.Controllers
{
    public class InfoesController : BaseController
    {
        private Model1 db = new Model1();

        // GET: Infoes
        public ActionResult Index()
        {
            int user_id = AuthorHelper.getIdentity().id;
            tblInfo info = db.tblInfoes.Find(user_id = user_id);
            if (info == null)
            {
                return RedirectToAction("Create");
            }
            return RedirectToAction("Edit",new { id = info.id});

        }

        // GET: Infoes/Details/5
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblInfo tblInfo = db.tblInfoes.Find(id);
            if (tblInfo == null)
            {
                return HttpNotFound();
            }
            string[] breadcrumb = { "Tài khoản", "Thông tin" };
            ViewBag.Breadcrumb = breadcrumb;
            return View(tblInfo);
        }

        // GET: Infoes/Create
        public ActionResult Create()
        {
            string[] breadcrumb = { "Tài khoản", "Thông tin" };
            ViewBag.Breadcrumb = breadcrumb;
            int user_id = (int)AuthorHelper.getIdentity().id;
            List<tblUser> tblUsers = db.tblUsers.Where(x => x.id == user_id).ToList();
            ViewBag.user_id = new SelectList(tblUsers, "id", "username");
            return View();
        }

        // POST: Infoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,user_id,sex,phone_number,address,date_of_bith,created_at")] tblInfo tblInfo)
        {
            string[] breadcrumb = { "Tài khoản", "Thông tin" };
            ViewBag.Breadcrumb = breadcrumb;
            if (ModelState.IsValid)
            {
                db.tblInfoes.Add(tblInfo);
                db.SaveChanges();
                AlertHelper.set("success", "Thêm thông tin cá nhân thành công");
                return RedirectToAction("Edit",new {id = tblInfo.id });
            }
            else
            {
                var errors = ModelState.Select(x => x.Value.Errors)
                       .Where(y => y.Count > 0)
                       .ToList();
            }
            int user_id = (int)AuthorHelper.getIdentity().id;
            List<tblUser> tblUsers = db.tblUsers.Where(x => x.id == user_id).ToList();
            ViewBag.user_id = new SelectList(tblUsers, "id", "username", tblInfo.user_id);
            return View(tblInfo);
        }

        // GET: Infoes/Edit/5
        public ActionResult Edit(int? id)
        {
            string[] breadcrumb = { "Tài khoản", "Thông tin" };
            ViewBag.Breadcrumb = breadcrumb;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblInfo tblInfo = db.tblInfoes.Find(id);
            if (tblInfo == null)
            {
                return HttpNotFound();
            }
            ViewBag.user_id = new SelectList(db.tblUsers.Where(x=>x.id == AuthorHelper.getIdentity().id).ToList(), "id", "username", tblInfo.user_id);
            return View(tblInfo);
        }

        // POST: Infoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,user_id,sex,phone_number,address,date_of_bith,created_at")] tblInfo tblInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblInfo).State = EntityState.Modified;
                db.SaveChanges();
                AlertHelper.set("success", "Cập nhập thông tin cá nhân thành công.");
                return RedirectToAction("Edit");
            }
            ViewBag.user_id = new SelectList(db.tblUsers, "id", "username", tblInfo.user_id);
            return View(tblInfo);
        }

        // GET: Infoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblInfo tblInfo = db.tblInfoes.Find(id);
            if (tblInfo == null)
            {
                return HttpNotFound();
            }
            return View(tblInfo);
        }

        // POST: Infoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblInfo tblInfo = db.tblInfoes.Find(id);
            db.tblInfoes.Remove(tblInfo);
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
