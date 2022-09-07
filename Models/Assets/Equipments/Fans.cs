using System;

namespace csharp_oop.Models.Assets
{
    public class Fans : GymAsset
    {
        public int FanNumber { get; set; }
        public string FanColor { get; set; }

        public Fans(int userInputNumberOfFans, string userInputColorOfFans, string nameOfAsset, decimal valueOfAsset, string userInputForStatus) : base(nameOfAsset, valueOfAsset, userInputForStatus)
        {
            FanNumber = userInputNumberOfFans;
            FanColor = userInputColorOfFans;
        }


    }
}

