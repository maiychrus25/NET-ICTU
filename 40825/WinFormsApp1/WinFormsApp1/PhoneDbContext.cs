using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class PhoneDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FPAM6VM\\SQLEXPRESS; Database=QuanLyDienThoai; Trusted_Connection=True; TrustServerCertificate=True");
        }
        public DbSet<Phone> Phones { get; set; }
    }
}
