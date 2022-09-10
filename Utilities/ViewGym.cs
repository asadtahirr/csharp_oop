using csharp_oop.Data;
using csharp_oop.Models;
using csharp_oop.Models.Assets;
using Microsoft.EntityFrameworkCore;

namespace csharp_oop.Utilities
{
    public class ViewGym
    {
        public ApplicationDbContext DbContext { get; set; }
        public Miscellanous Misc { get; set; }

        public ViewGym(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            Misc = new Miscellanous(dbContext);
        }

        public async Task ShowDetails()
        {
            List<BuildingViewModel> buildings = await Misc.PrintAllGyms();

            Console.WriteLine("\nSelect the gym you want to view\n");

            string selectedGym = Console.ReadLine();

            int selectedGymByUser = Convert.ToInt32(selectedGym);

            string selectedGymId = buildings[selectedGymByUser - 1].Id;

            Building gymDetails = await DbContext.Buildings
                                                    .Where(
                                                        b => b.Id == selectedGymId
                                                    )
                                                    .Include(
                                                        b => b.Employees
                                                    )
                                                    .Include(
                                                        b => b.Washrooms
                                                    )
                                                    .Include(
                                                        b => b.Rooms
                                                    )
                                                    .Include(
                                                        b => b.Customers
                                                    )
                                                    .FirstOrDefaultAsync();


            Console.WriteLine($"\nId: {gymDetails.Id}");

            Console.WriteLine($"Name: {gymDetails.Name}");

            Console.WriteLine($"Value: {gymDetails.Value}");

            Console.WriteLine($"Status: {gymDetails.Status}");

            Console.WriteLine($"OuterColor: {gymDetails.OuterColor}");

            Console.WriteLine($"InnerColor: {gymDetails.InnerColor}");

            Console.WriteLine($"Rooms: {gymDetails.Rooms.Count}");

            Console.WriteLine($"Washrooms: {gymDetails.Washrooms.Count}");

            Console.WriteLine($"Customers: {gymDetails.Customers.Count}");

            Console.WriteLine($"Employees: {gymDetails.Employees.Count}\n");
        }
    }
}
