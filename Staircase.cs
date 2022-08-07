using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    internal class Staircase : GymAsset
    {
        public string Equipment1 { get; set; }
        public string Equipment2 { get; set; }

        public Staircase(string nameOfAsset, decimal valueOfAsset) : base(nameOfAsset, valueOfAsset)
        {
            Equipment1 = "Stairs";
            Equipment2 = "Casing";
        }
    }
}
