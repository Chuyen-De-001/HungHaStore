namespace hung_ha.Models.DbSet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblInvoice")]
    public partial class tblInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblInvoice()
        {
            tlbInvoiceDetails = new HashSet<tlbInvoiceDetail>();
        }

        public int id { get; set; }

        public int user_id { get; set; }

        public int status { get; set; }

        public int total { get; set; }

        public int created_at { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tlbInvoiceDetail> tlbInvoiceDetails { get; set; }

        public virtual tblUser tblUser { get; set; }
    }
}
