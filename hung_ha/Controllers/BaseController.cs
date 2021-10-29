using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hung_ha.helpers;
using hung_ha.Models.DbSet;

namespace hung_ha.Controllers
{
    public class BaseController : Controller
    {
        Model1 db = new Model1();
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (AuthorHelper.isGuest())
            {
                filterContext.Result = new RedirectToRouteResult(
                    new System.Web.Routing.RouteValueDictionary(new { Controller = "User", Action = "Login" }));
            }
            base.OnActionExecuted(filterContext);
        }
    }
}