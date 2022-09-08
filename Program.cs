using csharp_oop.Data;
using csharp_oop.Models;
using csharp_oop.Models.Assets;
using csharp_oop.Models.Assets.Equipments;
using Microsoft.EntityFrameworkCore;

ApplicationDbContext dbContext = new ApplicationDbContext();

string activeOperation = null;

async Task PrintMainMenu()
{
    Console.WriteLine("Welcome to the gym console. What do you want to do?");

    Console.WriteLine("1. Create a new gym");

    Console.WriteLine("2. View gym details");

    Console.WriteLine("3. Update a gym");

    string selectedOption = Console.ReadLine();

    Console.WriteLine($"You have selected option {selectedOption}");

    if (selectedOption == "1")
    {
        await CreateNewGym();
    }
    else if (selectedOption == "2")
    {
        List<BuildingViewModel> buildings = await dbContext
                                    .Buildings
                                    .OrderBy(b => b.CreatedAt)
                                    .Select(b => new BuildingViewModel()
                                        {
                                            Name = b.Name,
                                            Id = b.Id
                                        }
                                    ).ToListAsync();


        for (int i = 1; i <= buildings.Count; i++)
        {
            Console.WriteLine($"{i}. {buildings[i - 1].Name}");
        }
        
        Console.WriteLine("Select the gym you want to update");
        
        string selectedGym = Console.ReadLine();

        int selectedGymByUser = Convert.ToInt32(selectedGym);

        string selectedGymId = buildings[selectedGymByUser - 1].Id;
        
        Building gymDetails = await dbContext.Buildings
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


        Console.WriteLine($"Id: {gymDetails.Id}");

        Console.WriteLine($"Name: {gymDetails.Name}");

        Console.WriteLine($"Value: {gymDetails.Value}");
        
        Console.WriteLine($"Status: {gymDetails.Status}");

        Console.WriteLine($"OuterColor: {gymDetails.OuterColor}");

        Console.WriteLine($"InnerColor: {gymDetails.InnerColor}");

        Console.WriteLine($"Rooms: {gymDetails.Rooms.Count}");

        Console.WriteLine($"Washrooms: {gymDetails.Washrooms.Count}");

        Console.WriteLine($"Customers: {gymDetails.Customers.Count}");

        Console.WriteLine($"Employees: {gymDetails.Employees.Count}");
    }
    else if (selectedOption == "3")
    {
        // do the other thing
    }
}

async Task CreateNewGym()
{
    Console.WriteLine("Please enter outer coler");

    string outerColor = Console.ReadLine();

    Console.WriteLine("Please enter inner color");

    string innercolor = Console.ReadLine();

    Console.WriteLine("Please enter name");

    string name = Console.ReadLine();

    Console.WriteLine("Please enter price");

    string userInputForPrice = Console.ReadLine();

    decimal price = Convert.ToDecimal(userInputForPrice);

    Console.WriteLine("Please enter the number of rooms you need");

    string userInputForRooms = Console.ReadLine();

    int numberOfRooms = Convert.ToInt32(userInputForRooms);

    Console.WriteLine("Please enter the number of employees you need in gym");

    string userInputForEmployees = Console.ReadLine();

    int numberOfEmployees = Convert.ToInt32(userInputForEmployees);

    Console.WriteLine("Please enter the number of washrooms you need");

    string userInputForWashrooms = Console.ReadLine();

    int numberOfWashrooms = Convert.ToInt32(userInputForWashrooms);

    Building newGym = new Building(outerColor, innercolor, name, price, "0");

    for (int i = 0; i < numberOfRooms; i++)
    {
        Room room = new Room(1, "random", "Individual Room", 1000, "0");

        newGym.Rooms.Add(room);
    }

    for (int i = 0; i < numberOfWashrooms; i++)
    {
        Washroom washrooms = new Washroom(4, "White", "Personal Washroom", 101, "1");

        newGym.Washrooms.Add(washrooms);
    }

    for (int i = 0; i < numberOfEmployees; i++)
    {
        Employee employees = new Employee("Manager", "day", "Muhammad", "Asad");

        newGym.Employees.Add(employees);
    }

    dbContext.Buildings.Add(newGym);

    await dbContext.SaveChangesAsync();

    Console.WriteLine("Done");
}

while (true)
{
    await PrintMainMenu();
}
