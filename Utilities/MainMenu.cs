namespace csharp_oop.Utilities
{
    public class MainMenu : Utility
    {
        public NewGym NewGym { get; set; }
        public ViewGym ViewGym { get; set; }
        public UpdateGym UpdateGym { get; set; }

        public MainMenu() : base()
        {
            NewGym = new NewGym(DbContext);
            ViewGym = new ViewGym(DbContext);
            UpdateGym = new UpdateGym(DbContext);
        }

        public async Task PrintMainMenu()
        {
            Console.WriteLine("Welcome to the gym console. What do you want to do?\n");

            Console.WriteLine("1. Create a new gym");

            Console.WriteLine("2. View gym details");

            Console.WriteLine("3. Update a gym\n");

            string selectedOption = Console.ReadLine();

            Console.WriteLine($"\nYou have selected option {selectedOption}\n");

            if (selectedOption == "1")
            {
                await NewGym.CreateNewGym();
            }
            else if (selectedOption == "2")
            {
                await ViewGym.ShowDetails();
            }
            else if (selectedOption == "3")
            {
                await UpdateGym.AmendDetails();
            }
        }
    }
}
