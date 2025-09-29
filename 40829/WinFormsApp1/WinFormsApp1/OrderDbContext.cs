using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WindowsFormOrders
{
    public class OrderDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Kết nối SQL Server, đổi chuỗi kết nối theo máy bạn
            optionsBuilder.UseSqlServer(
                "Server=.;Database=OrderDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
