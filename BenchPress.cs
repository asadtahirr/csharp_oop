using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    internal class BenchPress :GymAsset
    {
        public string Name1 { get; set; }
        public string Name2 { get; set; }

        public static string UnnecessaryProperty = "THis is unnecessary";

        public BenchPress(string userInputForName, decimal userInputForValue) : base(userInputForName , userInputForValue)       
        {
            Name1 = "Bench";
            Name2 = "Rod";
        }

        public static int DoWork()
        {
            return 5;
        }
    }
}
