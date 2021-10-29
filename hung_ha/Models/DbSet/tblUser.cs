namespace hung_ha.Models.DbSet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblUser
    {
        public const int ROLE_ADMIN = 1;
        public const int ROLE_CLIENT = 0;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUser()
        {
            tblInfoes = new HashSet<tblInfo>();
            tblInvoices = new HashSet<tblInvoice>();
        }

        [DisplayName("Mã tài khoản")]
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        [MinLength(6)]
        public string username { get; set; }

        [Required]
        [StringLength(255)]
        [MinLength(6)]
        public string password { get; set; }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string email { get; set; }

        public int role { get; set; }

        public int created_at { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInfo> tblInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInvoice> tblInvoices { get; set; }
    }
}
