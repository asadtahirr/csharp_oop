using System;

namespace csharp_oop.Models.Assets
{
    public class ReceptionArea : GymAsset
    {
        public string ReceptionEquipments { get; set; }
        public string ReceptionTheme { get; set; }

        public ReceptionArea(string equipmentsReception, string themeReception, string nameOfAsset, decimal valueOfAsset, string userInputForStatus) : base(nameOfAsset, valueOfAsset, userInputForStatus)
        {
            ReceptionEquipments = equipmentsReception;
            ReceptionTheme = themeReception;
        }


    }
}

