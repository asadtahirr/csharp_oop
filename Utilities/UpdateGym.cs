using csharp_oop.Data;
using csharp_oop.Models;
using csharp_oop.Models.Assets;
using Microsoft.EntityFrameworkCore;

namespace csharp_oop.Utilities
{
    public class UpdateGym
    {
        public ApplicationDbContext DbContext { get; set; }
        public Miscellanous Misc { get; set; }

        public UpdateGym(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            Misc = new Miscellanous(dbContext);
        }

        public async Task AmendDetails()
        {
            List<BuildingViewModel> buildings = await Misc.PrintAllGyms();

            Console.WriteLine("\nSelect the gym you want to update\n");

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

            Console.WriteLine($"\nYou have selected {gymDetails.Name}\n");

            Console.WriteLine("What do you want to update?\n");

            Console.WriteLine("1. Update name");
            Console.WriteLine("2. Update value");
            Console.WriteLine("3. Update status");
            Console.WriteLine("4. Update inner color");
            Console.WriteLine("5. Update outer color\n");

            string updateOption = Console.ReadLine();

            // add empty line
            Console.WriteLine();

            switch (updateOption)
            {
                case "1":
                    Console.WriteLine("Updating name\n");

                    Console.WriteLine($"Current name: {gymDetails.Name}");

                    Console.WriteLine("Please enter new name\n");

                    string name = Console.ReadLine();

                    gymDetails.Name = name;

                    break;

                case "2":
                    Console.WriteLine("Updating value\n");

                    Console.WriteLine($"Current value: {gymDetails.Value}");

                    Console.WriteLine("Please enter new value\n");

                    string value = Console.ReadLine();

                    decimal valueindecimal = Convert.ToDecimal(value);

                    gymDetails.Value = valueindecimal;

                    break;

                case "3":
                    Console.WriteLine("Updating status\n");

                    Console.WriteLine($"Current status: {gymDetails.Status}");

                    Console.WriteLine("Please enter new status\n");

                    string status = Console.ReadLine();

                    gymDetails.Status = status;

                    break;

                case "4":
                    Console.WriteLine("Updating inner color\n");

                    Console.WriteLine($"Current inner color: {gymDetails.InnerColor}");

                    Console.WriteLine("Please enter new inner color\n");

                    string innerColor = Console.ReadLine();

                    gymDetails.InnerColor = innerColor;

                    break;

                case "5":
                    Console.WriteLine("Updating outer color\n");

                    Console.WriteLine($"Current outer color: {gymDetails.OuterColor}");

                    Console.WriteLine("Please enter new outer color\n");

                    string outerColor = Console.ReadLine();

                    gymDetails.OuterColor = outerColor;

                    break;
            }

            await DbContext.SaveChangesAsync();

            Console.WriteLine("\nUpdated gym successfully");

            Console.WriteLine();
        }
    }
}
