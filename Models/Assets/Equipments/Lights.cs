using System;

namespace csharp_oop.Models.Assets.Equipments
{
    public class Lights : GymAsset
    {
        public int LightsRequired { get; set; }
        public string LightsColor { get; set; }

        public Lights(int NumberOfLights, string NewLighhtsColor, string nameOfAsset, decimal valueOfAsset, string userInputForStatus) : base(nameOfAsset, valueOfAsset, userInputForStatus)
        {
            LightsRequired = NumberOfLights;
            LightsColor = NewLighhtsColor;

        }
    }
}

