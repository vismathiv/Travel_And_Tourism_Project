using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Travel_And_Tourism_Project.Models
{
    public partial class TourismManagementContext : DbContext
    {
        public TourismManagementContext()
        {
        }

        public TourismManagementContext(DbContextOptions<TourismManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookingDetails> BookingDetails { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<PackageCategory> PackageCategory { get; set; }
        public virtual DbSet<PackageDetails> PackageDetails { get; set; }
        public virtual DbSet<Packages> Packages { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-CRQLOI6V\\SQLEXPRESS;Database=TourismManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingDetails>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK__booking___5DE3A5B14316E313");

                entity.ToTable("booking_details");

                entity.Property(e => e.BookingId).HasColumnName("booking_id");

                entity.Property(e => e.BookingDate)
                    .HasColumnName("booking_date")
                    .HasColumnType("date");

                entity.Property(e => e.BookingStatus)
                    .HasColumnName("booking_status")
                    .HasMaxLength(20);

                entity.Property(e => e.CId).HasColumnName("c_id");

                entity.Property(e => e.Noofadult).HasColumnName("noofadult");

                entity.Property(e => e.Noofchild).HasColumnName("noofchild");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.PayId).HasColumnName("pay_id");

                entity.Property(e => e.PdId).HasColumnName("pd_id");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.CId)
                    .HasConstraintName("FK__booking_de__c_id__49C3F6B7");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.PId)
                    .HasConstraintName("FK__booking_de__p_id__48CFD27E");

                entity.HasOne(d => d.Pay)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.PayId)
                    .HasConstraintName("FK__booking_d__pay_i__4BAC3F29");

                entity.HasOne(d => d.Pd)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.PdId)
                    .HasConstraintName("FK__booking_d__pd_id__4AB81AF0");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK__customer__213EE774E7B02A76");

                entity.ToTable("customer");

                entity.Property(e => e.CId).HasColumnName("c_id");

                entity.Property(e => e.CAddress)
                    .HasColumnName("c_address")
                    .HasMaxLength(200);

                entity.Property(e => e.CAge).HasColumnName("c_age");

                entity.Property(e => e.CEmail)
                    .HasColumnName("c_email")
                    .HasMaxLength(20);

                entity.Property(e => e.CFname)
                    .HasColumnName("c_fname")
                    .HasMaxLength(20);

                entity.Property(e => e.CLname)
                    .HasColumnName("c_lname")
                    .HasMaxLength(20);

                entity.Property(e => e.CPhone)
                    .HasColumnName("c_phone")
                    .HasMaxLength(10);

                entity.Property(e => e.Noofpersons).HasColumnName("noofpersons");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.PId)
                    .HasConstraintName("FK__customer__p_id__3B75D760");
            });

            modelBuilder.Entity<PackageCategory>(entity =>
            {
                entity.HasKey(e => e.PcatId)
                    .HasName("PK__PackageC__67E79657D7F83E06");

                entity.Property(e => e.PcatId).HasColumnName("pcat_id");

                entity.Property(e => e.PcatDescription)
                    .HasColumnName("pcat_description")
                    .HasMaxLength(200);

                entity.Property(e => e.PcatName)
                    .HasColumnName("pcat_name")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<PackageDetails>(entity =>
            {
                entity.HasKey(e => e.PdId)
                    .HasName("PK__PackageD__F7562CCFEE6B3063");

                entity.Property(e => e.PdId).HasColumnName("pd_id");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.PdDays).HasColumnName("pd_days");

                entity.Property(e => e.PdDescription)
                    .HasColumnName("pd_description")
                    .HasMaxLength(200);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.PackageDetails)
                    .HasForeignKey(d => d.PId)
                    .HasConstraintName("FK__PackageDet__p_id__3E52440B");
            });

            modelBuilder.Entity<Packages>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("PK__Packages__82E06B91AD6FC221");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.PDestination)
                    .HasColumnName("p_destination")
                    .HasMaxLength(20);

                entity.Property(e => e.PEnddate)
                    .HasColumnName("p_enddate")
                    .HasColumnType("date");

                entity.Property(e => e.PName)
                    .HasColumnName("p_name")
                    .HasMaxLength(60);

                entity.Property(e => e.PNoofdays).HasColumnName("p_noofdays");

                entity.Property(e => e.PPrice).HasColumnName("p_price");

                entity.Property(e => e.PStartdate)
                    .HasColumnName("p_startdate")
                    .HasColumnType("date");

                entity.Property(e => e.PcatId).HasColumnName("pcat_id");

                entity.HasOne(d => d.Pcat)
                    .WithMany(p => p.Packages)
                    .HasForeignKey(d => d.PcatId)
                    .HasConstraintName("FK__Packages__pcat_i__38996AB5");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.PayId)
                    .HasName("PK__Payment__7AAD1CEAAA92C096");

                entity.Property(e => e.PayId).HasColumnName("pay_id");

                entity.Property(e => e.CId).HasColumnName("c_id");

                entity.Property(e => e.PayDate)
                    .HasColumnName("pay_date")
                    .HasColumnType("date");

                entity.Property(e => e.PayPrice).HasColumnName("pay_price");

                entity.Property(e => e.PayType)
                    .HasColumnName("pay_type")
                    .HasMaxLength(20);

                entity.HasOne(d => d.C)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.CId)
                    .HasConstraintName("FK__Payment__c_id__412EB0B6");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
