using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hung_ha.Models.DbSet
{
    public class cart
    {
        public int product_id { get; set; }
        public int quantity { get; set; }
        public int total { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string img { get; set; }
    }
}