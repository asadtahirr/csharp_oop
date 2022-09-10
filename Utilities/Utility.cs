using csharp_oop.Data;

namespace csharp_oop.Utilities
{
    public abstract class Utility
    {
        public ApplicationDbContext DbContext { get; set; }

        public Utility()
        {
            DbContext = new ApplicationDbContext();
        }
    }
}
