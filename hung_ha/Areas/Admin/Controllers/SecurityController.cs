using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hung_ha.Models.Form;
using hung_ha.Models.DbSet;
using hung_ha.helpers;

namespace hung_ha.Areas.Admin.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Admin/Security
        Model1 db = new Model1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginForm model)
        {
            ViewBag.Breadcrumb = new string[] { "Tài khoản", "Đăng nhập" };
            try
            {
                if (ModelState.IsValid)
                {
                    if (model.login())
                    {
                        tblUser user = db.tblUsers.Find(AuthorHelper.getIdentity().id);
                        if(user.role != tblUser.ROLE_ADMIN)
                        {
                            AlertHelper.set("warning", "Tài khoản khhoong có quyền đăng nhập vào trang quản trị.");
                            return RedirectToAction("Login", "Security");
                        }
                        AlertHelper.set("success", "Đăng nhập thành công!");
                        return RedirectToAction("Index", "Site");
                    }
                }
                return View(model);
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}