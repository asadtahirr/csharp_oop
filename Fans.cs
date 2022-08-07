using System;
namespace csharp_oop
{
    public class Fans : GymAsset
        {
       public int FanNumber { get; set; }
        public string FanColor { get; set; }

        public Fans(int userInputNumberOfFans, string userInputColorOfFans, string nameOfAsset, decimal valueOfAsset) : base (nameOfAsset, valueOfAsset)
        {
            FanNumber = userInputNumberOfFans;
            FanColor = userInputColorOfFans;
        }

        
    }
}

