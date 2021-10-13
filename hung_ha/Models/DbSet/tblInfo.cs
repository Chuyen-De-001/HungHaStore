namespace hung_ha.Models.DbSet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblInfo")]
    public partial class tblInfo
    {
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? user_id { get; set; }

        [StringLength(50)]
        public string sex { get; set; }

        [StringLength(50)]
        public string phone_number { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        public int? date_of_bith { get; set; }

        public int created_at { get; set; }

        public virtual tblUser tblUser { get; set; }
    }
}
