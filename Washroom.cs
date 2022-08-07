using System;
namespace csharp_oop
{
    public class Washroom : GymAsset
    {
       public int NumberOfToilets { get; set; }
        public string ThemeofWashroom { get; set; }

        public Washroom(int numofToilets, string themeofWashroom, string nameOfAsset, decimal valueOfAsset) : base(nameOfAsset, valueOfAsset)
        {
            NumberOfToilets = numofToilets;
            ThemeofWashroom = themeofWashroom;
        }

    }
}

