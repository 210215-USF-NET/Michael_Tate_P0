using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StoreDL.Entities
{
    public partial class StoreAppDBContext : DbContext
    {
        public StoreAppDBContext()
        {
        }

        public StoreAppDBContext(DbContextOptions<StoreAppDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("firstName")
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("lastName")
                    .IsFixedLength(true);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("address")
                    .IsFixedLength(true);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("city")
                    .IsFixedLength(true);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("state")
                    .IsFixedLength(true);

                entity.Property(e => e.Zip).HasColumnName("zip");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("orderDate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.CustomerNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Customer)
                    .HasConstraintName("FK__Orders__Customer__3D2915A8");

                entity.HasOne(d => d.LocationNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Location)
                    .HasConstraintName("FK__Orders__Location__3C34F16F");

                entity.HasOne(d => d.ProductNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Product)
                    .HasConstraintName("FK__Orders__Product__3E1D39E1");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.SliceCount).HasColumnName("sliceCount");

                entity.Property(e => e.WholeCount).HasColumnName("wholeCount");

                entity.HasOne(d => d.LocationNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Location)
                    .HasConstraintName("FK__Product__Locatio__3864608B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
