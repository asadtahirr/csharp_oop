using csharp_oop.Models;
using csharp_oop.Models.Assets;
using csharp_oop.Models.Assets.Equipments;
using Microsoft.EntityFrameworkCore;

namespace csharp_oop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Washroom> Washrooms { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=csharp_oop;Trusted_Connection=True;MultipleActiveResultSets=true";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
