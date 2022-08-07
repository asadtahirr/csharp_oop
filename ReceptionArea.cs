using System;
namespace csharp_oop
{
    public class ReceptionArea : GymAsset
    {
        public string ReceptionEquipments { get; set; }
        public string ReceptionTheme { get; set; }

        public ReceptionArea(string equipmentsReception, string themeReception, string nameOfAsset, decimal valueOfAsset) : base(nameOfAsset, valueOfAsset)
        {
            ReceptionEquipments = equipmentsReception;
            ReceptionTheme = themeReception;
        }


    }
}

