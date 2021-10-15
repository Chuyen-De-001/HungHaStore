using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace hung_ha.Models.DbSet
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagram { get; set; }
        public virtual DbSet<tblInfo> tblInfoe { get; set; }
        public virtual DbSet<tblInvoice> tblInvoice { get; set; }
        public virtual DbSet<tblProduct> tblProduct { get; set; }
        public virtual DbSet<tblProductCategory> tblProductCategorie { get; set; }
        public virtual DbSet<tblStore> tblStore { get; set; }
        public virtual DbSet<tblUser> tblUser { get; set; }
        public virtual DbSet<tlbInvoiceDetail> tlbInvoiceDetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblInvoice>()
                .HasMany(e => e.tlbInvoiceDetails)
                .WithRequired(e => e.tblInvoice)
                .HasForeignKey(e => e.invoice_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<tblProduct>()
                .HasMany(e => e.tlbInvoiceDetails)
                .WithRequired(e => e.tblProduct)
                .HasForeignKey(e => e.product_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProduct>()
                .HasMany(e => e.tblStores)
                .WithRequired(e => e.tblProduct)
                .HasForeignKey(e => e.product_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProductCategory>()
                .HasMany(e => e.tblProducts)
                .WithOptional(e => e.tblProductCategory)
                .HasForeignKey(e => e.category_id);

            modelBuilder.Entity<tblUser>()
                .HasMany(e => e.tblInfoes)
                .WithOptional(e => e.tblUser)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<tblUser>()
                .HasMany(e => e.tblInvoices)
                .WithRequired(e => e.tblUser)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);
        }
    }
}
