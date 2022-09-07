using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop.Models.Assets.Equipments
{
    internal class Staircase : GymAsset
    {
        public string Equipment1 { get; set; }
        public string Equipment2 { get; set; }

        public Staircase(string nameOfAsset, decimal valueOfAsset, string statusOfAsset) : base(nameOfAsset, valueOfAsset, statusOfAsset)
        {
            Equipment1 = "Stairs";
            Equipment2 = "Casing";
        }
    }
}
