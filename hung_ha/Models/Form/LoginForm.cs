using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hung_ha.Models.DbSet;
using hung_ha.Models.DAO;
using hung_ha.helpers;
using System.ComponentModel.DataAnnotations;

namespace hung_ha.Models.Form
{
    public class LoginForm:User
    {
        [Required]
        [MinLength(6)]
        public string username { get; set; }

        [Required]
        [MinLength(6)]
        public string password { get; set; }

        public bool login()
        {
            try
            {
                string password = PasswordHelper.MD5(this.password) ;
                var user = context.tblUsers.Where(s => s.username == this.username && s.password == password).Single();
                if (user != null)
                {
                    AuthorHelper.setIdentity(user);
                    return true;
                }
            }
            catch { }
            return false;
        }
            
    }
}