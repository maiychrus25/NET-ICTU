using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace WindowsFormDemo
{
    internal class SupplierDbContext : DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // NOTE: sửa connection string này theo máy bạn
            optionsBuilder.UseSqlServer("Server=;Database=QuanLyNhaCungCap;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(200);

            modelBuilder.Entity<Supplier>()
                .Property(s => s.Email)
                .HasMaxLength(200);

            modelBuilder.Entity<Supplier>()
                .Property(s => s.Phone)
                .HasMaxLength(50);

            modelBuilder.Entity<Supplier>()
                .Property(s => s.Address)
                .HasMaxLength(500);
        }
    }
}
