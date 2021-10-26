using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hung_ha.Models.DbSet;
using PagedList;

namespace hung_ha.Models.DAO
{
    public class Product
    {
        public static Model1 context = new Model1();
        public Product(){}

        public static List<tblProduct> findAll()
        {
            var list = context.tblProducts.ToList();
            return list;
        }

        public static List<tblProduct> findLimit(int limit = 20)
        {
            Random rand = new Random();
            int toSkip = rand.Next(0, context.tblProducts.Count());
            var list = context.tblProducts.OrderBy(s=>s.id).Skip(toSkip).Take(limit).ToList();
            return list;
        }

       public static tblProduct findOne(int id)
        {
            try
            {
                var product = context.tblProducts.Where(s => s.id == id).Single();
                return product;
            }
            catch
            {
                return null;
            }
            
        }

        public static List<tblProduct> findByCategory(int? category)
        {
            try
            {
                var list = context.tblProducts.Where(s => s.category_id == category).Take(20).ToList();
                return list;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public static List<tblProduct> findByView(int limit = 15)
        {
            try
            {
                var list = context.tblProducts.OrderByDescending(s=>s.views).Take(limit).ToList();
                return list;
            }
            catch { }
            return null;
        }

        public static IEnumerable<tblProduct> findAllPageList(int page, int pageSize,string search ="",string category_id="")
        {
            try
            {
                string query = "select * from tblProduct inner join tblProductCategory on tblProduct.category_id = tblProductCategory.id where 1 = 1";
                if (search != "")
                {
                    query += "and ( tblProductCategory.name like N'%" + search + "%' or tblProduct.name like N'%" + search + "%' )";
                }

                if (category_id != "")
                {
                    query += " and tblProduct.category_id = " + category_id;
                }
                var list = context.tblProducts.SqlQuery(query).ToPagedList(page, pageSize);
                return list;
            }catch(Exception e) { }
            return null;
        }
    }
}