using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop.Models.Assets.Equipments
{
    internal class Treadmill : GymAsset
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Part3 { get; set; }

        public Treadmill(string nameOfAsset, decimal valueOfAsset, string statusOfAsset) : base(nameOfAsset, valueOfAsset, statusOfAsset)
        {
            Part1 = "Belt";
            Part2 = "Handle";
            Part3 = "Motor";
        }
    }
}
