using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hung_ha.Models.DbSet;
using System.Web.Mvc;

namespace hung_ha.Controllers
{
    public class BaseController : Controller
    {
        public Model1 db = new Model1();
        public BaseController()
        {

        }

        // GET: Base
        public ActionResult Index()
        {
            return View();
        }
    }
}