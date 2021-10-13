using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hung_ha.Models.DbSet;

namespace hung_ha.Models.DAO
{
    public class Product
    {
        public static Model1 context = new Model1();
        public Product(){}

        public static List<tblProduct> findAll()
        {
            var list = context.tblProduct.ToList();
            return list;
        }

        public static List<tblProduct> findLimit(int limit = 20)
        {
            Random rand = new Random();
            int toSkip = rand.Next(0, context.tblProduct.Count());
            var list = context.tblProduct.OrderBy(s=>s.id).Skip(toSkip).Take(limit).ToList();
            return list;
        }

       public static tblProduct findOne(int id)
        {
            try
            {
                var product = context.tblProduct.Where(s => s.id == id).Single();
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
                Random rand = new Random();
                int toSkip = rand.Next(0, context.tblProduct.Count());
                var list = context.tblProduct.Where(s => s.category_id == category).Skip(toSkip).Take(7).ToList();
                return list;
            }
            catch
            {
                return null;
            }
        }
    }
}