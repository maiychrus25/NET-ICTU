using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormDemo
{
    internal class BookDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=; Database=QuanLySach; Trusted_Connection=True; TrustServerCertificate=True");
        }

        public DbSet<Book> Books { get; set; }
    }
}
