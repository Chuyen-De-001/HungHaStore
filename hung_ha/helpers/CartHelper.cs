using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hung_ha.Models.DbSet;

namespace hung_ha.helpers
{
    public class CartHelper
    {
        public static List<cart> Add(tblProduct product)
        {
            List<cart> list = new List<cart>();
            try
            {
                if (HttpContext.Current.Session["cartSession"] != null)
                {
                    list = (List<cart>)HttpContext.Current.Session["cartSession"];
                }
            }
            catch { }
            var cart = new cart();
            cart.product_id = product.id;
            cart.img = product.img;
            cart.name = product.name;
            cart.price = (int)product.price;
            cart.quantity = 1;
            cart.total = cart.quantity * cart.price;
            cart model = CartHelper.isExist(cart, list);
            if (model != null)
            {
                model.quantity = model.quantity + 1;
                model.total = model.quantity * model.price;
                CartHelper.updateOne(model, list);
            }
            else
            {
                list.Add(cart);
            }
            CartHelper.setList(list);
            return list;
        }

        public static cart isExist(cart model, List<cart> list)
        {
            try
            {
                if (list == null)
                {
                    return null;
                }
                foreach (cart item in list)
                {
                    if (item.product_id == model.product_id)
                    {
                        return item;
                    }
                }
            }
            catch { }
            return null;
        }

        public static void updateOne(cart cart, List<cart> list = null)
        {
            foreach (cart item in list)
            {
                if (item.product_id == cart.product_id)
                {
                    item.quantity = cart.quantity;
                    item.total = cart.total;
                }
            }
        }

        public static List<cart> list()
        {
            List<cart> list = new List<cart>();
            try
            {
                if (HttpContext.Current.Session["cartSession"] != null)
                {
                    list = (List<cart>)HttpContext.Current.Session["cartSession"];
                    return list;
                }
            }
            catch { }
            return null;
        }

        public static int count()
        {
            try
            {
                List<cart> list = CartHelper.list();
                if(list == null)
                {
                    return 0;
                }
                return list.Count;
            }
            catch{}
            return 0;
        }

        public static int sum()
        {
            int total = 0;
            try
            {
                List<cart> list = CartHelper.list();
                if(list == null) { return 0; }
                foreach (cart item in list) {
                    total += item.total;
                }
            }
            catch { }
            return total;
        }

        public static cart findOne(int product_id)
        {
            List<cart> list = CartHelper.list();
            foreach (cart item in list)
            {   
                if(item.product_id == product_id)
                {
                    return item;
                }
            }
            return null;
        }

        public static void setList(List<cart> list)
        {
            HttpContext.Current.Session["cartSession"] = list;
        }
    }


}