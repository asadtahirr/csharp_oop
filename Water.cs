using System;
namespace csharp_oop
{
    public class Water : GymAsset
    {
        public int NumberOfWaterOutlets { get; set; }
        public string waterSource { get; set; }

        public Water(int WaterOutlets,string sourceWater, string nameOfAsset, decimal valueOfAsset) : base(nameOfAsset, valueOfAsset)
        {
            NumberOfWaterOutlets = WaterOutlets;
            waterSource = sourceWater;
        }
    }
}

