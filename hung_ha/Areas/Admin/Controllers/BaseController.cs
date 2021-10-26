using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hung_ha.helpers;

namespace hung_ha.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (AuthorHelper.isGuest())
            {
                filterContext.Result = new RedirectToRouteResult(
                    new System.Web.Routing.RouteValueDictionary(new { Controller = "Security", Action = "Login" }));
            }
            base.OnActionExecuted(filterContext);
        }
    }
}