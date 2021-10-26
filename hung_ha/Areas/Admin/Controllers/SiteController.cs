using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hung_ha.Areas.Admin.Controllers
{
    public class SiteController : BaseController
    {
        // GET: Admin/Site
        public ActionResult Index()
        {
            return View();
        }
    }
}