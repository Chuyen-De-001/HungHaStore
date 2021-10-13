using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hung_ha.Models.DbSet;
using hung_ha.Models.DAO;

namespace hung_ha.helpers
{
    public class AuthorHelper:User
    {
        public static void setIdentity(tblUser user)
        {
            HttpContext.Current.Session["loginSesstion"] = user;
        }

        public static tblUser getIdentity()
        {
            try
            {
                return (tblUser)HttpContext.Current.Session["loginSesstion"];
            }
            catch
            {
                return null;
            }
        }

        public static void removeIdentity()
        {
            HttpContext.Current.Session["loginSesstion"] = null;
        }

        public static bool isGuest()
        {
            if(HttpContext.Current.Session["loginSesstion"] == null)
            {
                return true;
            }
            return false;
        }
    }
}