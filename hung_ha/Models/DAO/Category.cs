using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hung_ha.Models.DbSet;

namespace hung_ha.Models.DAO
{
    public class Category
    {
        public static Model1 context = new Model1();
        public Category() { }

        public static IEnumerable<tblProductCategory> findAll()
        {
            try
            {
                IEnumerable<tblProductCategory> list;
                list = context.tblProductCategories.ToList();
                return list;
            }
            catch(Exception e)
            {}
            return null;
        }
    }
}