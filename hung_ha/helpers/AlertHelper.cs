using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hung_ha.helpers
{
    public class AlertHelper
    {
        public static string template = "<div class=\"alert alert-{{type}} alert-dismissible fade show\" role=\"alert\">{{message}}<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button></div>";

        public static void set(string type,string mess)
        {
            HttpContext.Current.Session["alertTypeSession"] = type;
            HttpContext.Current.Session["alertMessageSession"] = mess;
        }

        public static string get(string code)
        {
            if (code == "type")
            {
                string type = (string)HttpContext.Current.Session["alertTypeSession"];
                HttpContext.Current.Session.Remove("alertTypeSession");
                return type;
            }
            string message = (string)HttpContext.Current.Session["alertMessageSession"];
            HttpContext.Current.Session.Remove("alertMessageSession");
            return message;
        }

        public static bool isAlert()
        {
            if (HttpContext.Current.Session["alertTypeSession"] != null && HttpContext.Current.Session["alertMessageSession"] != null)
            {
                return true;
            }
            return false;
        }


    }
}