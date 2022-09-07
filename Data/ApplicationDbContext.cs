using csharp_oop.Models.Assets;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=csharp_oop;Trusted_Connection=True;MultipleActiveResultSets=true";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
