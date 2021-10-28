using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hung_ha.Models.DbSet;
using PagedList;

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
            catch (Exception e)
            { }
            return null;
        }

        public static IEnumerable<tblProductCategory> findAllPageList(int page, int pageSize, string search = "")
        {
            try
            {
                string query = "select * from tblProductCategory where 1 = 1";
                if (search != "")
                {
                    query += "and ( tblProductCategory.name like N'%" + search + "%' or tblProductCategory.id like N'%" + search + "%' )";
                }
                var list = context.tblProductCategories.SqlQuery(query).ToPagedList(page, pageSize);
                return list;
            }
            catch (Exception e) { }
            return null;
        }
    }
}