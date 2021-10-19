using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hung_ha.Models.DbSet;
using hung_ha.Models.DAO;
using System.ComponentModel.DataAnnotations;

namespace hung_ha.Models.Form
{
    public class RegisterForm:User
    {
        [Required]
        [StringLength(255)]
        [MinLength(6)]
        public string username { set; get; }

        [Required]
        [StringLength(255)]
        [MinLength(6)]
        public string password { set; get; }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string email { set; get; }

        public tblUser register(tblUser user)
        {
            try
            {
                context.tblUsers.Add(user);
                context.SaveChanges();
                return user;
            }
            catch
            {
                return null;
            }
        }

        private tblUser RedirectToAction(string v, object p)
        {
            throw new NotImplementedException();
        }
    }
}