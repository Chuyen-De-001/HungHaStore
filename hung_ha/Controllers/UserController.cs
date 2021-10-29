using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hung_ha.Models.DbSet;
using hung_ha.Models.DAO;
using hung_ha.Models.Form;
using System.Web.Helpers;
using hung_ha.helpers;
using System.Web.Security;
using System.Net;

namespace hung_ha.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        Model1 db = new Model1();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            ViewBag.Breadcrumb = new string[] { "Tài khoản", "Đăng ký" };
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterForm model)
        {
            ViewBag.Breadcrumb = new string[] { "Tài khoản", "Đăng ký" };
            try
            {
                if (ModelState.IsValid)
                {
                    var user = new tblUser();
                    user.username = model.username;
                    user.email = model.email;
                    user.password = PasswordHelper.MD5(model.password);
                    user.role = tblUser.ROLE_CLIENT;
                    user.created_at = TimeHelper.getTimeUnix();
                    if ((user = model.register(user)) != null)
                    {
                        return RedirectToAction("Login", "User");
                    }
                }
                return View(model);
            }
            catch(Exception e)
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Breadcrumb = new string[] { "Tài khoản", "Đăng nhập" };
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
                        AlertHelper.set("success", "Đăng nhập thành công!");
                        return RedirectToAction("Index", "Home");
                    }
                }
                return View(model);
            }
            catch(Exception e)
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            AuthorHelper.removeIdentity();
            return RedirectToAction("Index", "Home");
        }
    }
}