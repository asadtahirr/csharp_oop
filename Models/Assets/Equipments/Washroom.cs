using System;

namespace csharp_oop.Models.Assets.Equipments
{
    public class Washroom : GymAsset
    {
        public int NumberOfToilets { get; set; }
        public string ThemeofWashroom { get; set; }

        public Washroom(int numofToilets, string themeofWashroom, string nameOfAsset, decimal valueOfAsset, string statusOfAsset) : base(nameOfAsset, valueOfAsset, statusOfAsset)
        {
            NumberOfToilets = numofToilets;
            ThemeofWashroom = themeofWashroom;
        }

    }
}

