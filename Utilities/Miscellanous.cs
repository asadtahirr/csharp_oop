using csharp_oop.Data;
using csharp_oop.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_oop.Utilities
{
    public class Miscellanous
    {
        public ApplicationDbContext DbContext { get; set; }

        public Miscellanous(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<List<BuildingViewModel>> PrintAllGyms()
        {
            List<BuildingViewModel> buildings = await DbContext
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
    }
}
