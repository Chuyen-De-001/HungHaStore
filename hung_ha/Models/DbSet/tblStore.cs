namespace hung_ha.Models.DbSet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblStore
    {
        public int id { get; set; }

        public int product_id { get; set; }

        public int quantity { get; set; }

        public int status { get; set; }

        public int created_at { get; set; }

        public virtual tblProduct tblProduct { get; set; }
    }
}
