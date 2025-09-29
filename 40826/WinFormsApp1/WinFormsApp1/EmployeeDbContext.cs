using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WindowsFormDemo
{
    internal class EmployeeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-FPAM6VM\\SQLEXPRESS; Database=QuanLyNhanVien; Trusted_Connection=True; TrustServerCertificate=True");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
