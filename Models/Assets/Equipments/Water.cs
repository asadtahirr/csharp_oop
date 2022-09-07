using System;

namespace csharp_oop.Models.Assets.Equipments
{
    public class Water : GymAsset
    {
        public int NumberOfWaterOutlets { get; set; }
        public string waterSource { get; set; }

        public Water(int WaterOutlets, string sourceWater, string nameOfAsset, decimal valueOfAsset, string statusOfAsset) : base(nameOfAsset, valueOfAsset, statusOfAsset)
        {
            NumberOfWaterOutlets = WaterOutlets;
            waterSource = sourceWater;
        }
    }
}

