using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WindowsFormDemo
{
    internal class ProductDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=; Database=QuanLySanPham; Trusted_Connection=True; TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }
    }
}
