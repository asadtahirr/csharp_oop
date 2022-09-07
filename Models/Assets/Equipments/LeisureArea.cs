using System;

namespace csharp_oop.Models.Assets
{
    public class LeisureArea : GymAsset
    {
        public string EquipmentsNeededInLeisureArea { get; set; }
        public string Color { get; set; }

        public LeisureArea(
            string equipmentsLeisureArea,
            string colorLeisureArea,
            string userInputForName,
            decimal userInputForValue,
            string userInputForStatus
        ) : base(userInputForName, userInputForValue, userInputForStatus)
        {
            EquipmentsNeededInLeisureArea = equipmentsLeisureArea;
            Color = colorLeisureArea;
        }
    }
}

