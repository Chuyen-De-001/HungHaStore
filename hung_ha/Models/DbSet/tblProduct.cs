namespace hung_ha.Models.DbSet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProduct")]
    public partial class tblProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProduct()
        {
            tlbInvoiceDetails = new HashSet<tlbInvoiceDetail>();
            tblStores = new HashSet<tblStore>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? category_id { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int? price { get; set; }

        public int? created_at { get; set; }

        [StringLength(255)]
        public string img { get; set; }

        public int? views { get; set; }

        public int? sale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tlbInvoiceDetail> tlbInvoiceDetails { get; set; }

        public virtual tblProductCategory tblProductCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStore> tblStores { get; set; }
    }
}
