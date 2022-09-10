using csharp_oop.Data;
using csharp_oop.Models;
using csharp_oop.Models.Assets;
using csharp_oop.Models.Assets.Equipments;

namespace csharp_oop.Utilities
{
    public class NewGym
    {
        public ApplicationDbContext DbContext { get; set; }

        public NewGym(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task CreateNewGym()
        {
            Console.WriteLine("Please enter name\n");

            string name = Console.ReadLine();

            Console.WriteLine("\nPlease enter price\n");

            string userInputForPrice = Console.ReadLine();

            decimal price = Convert.ToDecimal(userInputForPrice);

            Console.WriteLine("\nPlease enter outer color\n");

            string outerColor = Console.ReadLine();

            Console.WriteLine("\nPlease enter inner color\n");

            string innercolor = Console.ReadLine();

            Console.WriteLine("\nPlease enter the number of rooms you need\n");

            string userInputForRooms = Console.ReadLine();

            int numberOfRooms = Convert.ToInt32(userInputForRooms);

            Console.WriteLine("\nPlease enter the number of employees you need in gym\n");

            string userInputForEmployees = Console.ReadLine();

            int numberOfEmployees = Convert.ToInt32(userInputForEmployees);

            Console.WriteLine("\nPlease enter the number of washrooms you need\n");

            string userInputForWashrooms = Console.ReadLine();

            int numberOfWashrooms = Convert.ToInt32(userInputForWashrooms);

            Building newGym = new Building(outerColor, innercolor, name, price, "functional");

            for (int i = 0; i < numberOfRooms; i++)
            {
                Room room = new Room(1, "Random", "Individual Room", 1000, "functional");

                newGym.Rooms.Add(room);
            }

            for (int i = 0; i < numberOfWashrooms; i++)
            {
                Washroom washrooms = new Washroom(4, "White", "Personal Washroom", 101, "functional");

                newGym.Washrooms.Add(washrooms);
            }

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Employee employees = new Employee("Manager", "day", "Muhammad", "Asad");

                newGym.Employees.Add(employees);
            }

            DbContext.Buildings.Add(newGym);

            await DbContext.SaveChangesAsync();

            Console.WriteLine("\nDone\n");
        }
    }
}
