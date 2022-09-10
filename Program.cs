using csharp_oop.Data;
using csharp_oop.Models;
using csharp_oop.Models.Assets;
using csharp_oop.Models.Assets.Equipments;
using Microsoft.EntityFrameworkCore;

ApplicationDbContext dbContext = new ApplicationDbContext();

string activeOperation = null;

async Task CreateNewGym()
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

    dbContext.Buildings.Add(newGym);

    await dbContext.SaveChangesAsync();

    Console.WriteLine("\nDone\n");
}

async Task<List<BuildingViewModel>> PrintAllGyms()
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

    return buildings;
}

async Task ViewGymDetails()
{
    List<BuildingViewModel> buildings = await PrintAllGyms();

    Console.WriteLine("\nSelect the gym you want to view\n");

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

async Task UpdateGym()
{

    List<BuildingViewModel> buildings = await PrintAllGyms();

    Console.WriteLine("\nSelect the gym you want to update\n");

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

            await dbContext.SaveChangesAsync();

            break;

        case "2":
            Console.WriteLine("Updating value\n");

            Console.WriteLine($"Current value: {gymDetails.Value}");

            Console.WriteLine("Please enter new value\n");

            string value = Console.ReadLine();

            decimal valueindecimal = Convert.ToDecimal(value);

            gymDetails.Value = valueindecimal;

            await dbContext.SaveChangesAsync();

            break;

        case "3":
            Console.WriteLine("Updating status\n");

            Console.WriteLine($"Current status: {gymDetails.Status}");

            Console.WriteLine("Please enter new status\n");

            string status = Console.ReadLine();

            gymDetails.Status = status;

            await dbContext.SaveChangesAsync();

            break;

        case "4":
            Console.WriteLine("Updating inner color\n");

            Console.WriteLine($"Current inner color: {gymDetails.InnerColor}");

            Console.WriteLine("Please enter new inner color\n");

            string innerColor = Console.ReadLine();
           
            gymDetails.InnerColor = innerColor;
     
            await dbContext.SaveChangesAsync();

            break;

        case "5":
            Console.WriteLine("Updating outer color\n");

            Console.WriteLine($"Current outer color: {gymDetails.OuterColor}");

            Console.WriteLine("Please enter new outer color\n");

            string outerColor = Console.ReadLine();

            gymDetails.OuterColor = outerColor;

            await dbContext.SaveChangesAsync();

            break;

        default:
            Console.WriteLine("Please select an option to continue\n");

            break;
    }

    Console.WriteLine();
}

async Task PrintMainMenu()
{
    Console.WriteLine("Welcome to the gym console. What do you want to do?\n");

    Console.WriteLine("1. Create a new gym");

    Console.WriteLine("2. View gym details");

    Console.WriteLine("3. Update a gym\n");

    string selectedOption = Console.ReadLine();

    Console.WriteLine($"\nYou have selected option {selectedOption}\n");

    if (selectedOption == "1")
    {
        await CreateNewGym();
    }
    else if (selectedOption == "2")
    {
        await ViewGymDetails();
    }
    else if (selectedOption == "3")
    {
        await UpdateGym();
    }
}

while (true)
{
    await PrintMainMenu();
}
