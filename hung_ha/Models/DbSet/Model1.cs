using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace hung_ha.Models.DbSet
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Database")
        {
        }

        public virtual DbSet<tblInfo> tblInfoes { get; set; }
        public virtual DbSet<tblInvoice> tblInvoices { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblProductCategory> tblProductCategories { get; set; }
        public virtual DbSet<tblStore> tblStores { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tlbInvoiceDetail> tlbInvoiceDetails { get; set; }

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
