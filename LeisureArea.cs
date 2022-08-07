using System;
namespace csharp_oop
{
    public class LeisureArea : GymAsset
    {
        public  string EquipmentsNeededInLeisureArea { get; set; }
        public string Color { get; set; }

        public LeisureArea(
            string equipmentsLeisureArea,
            string colorLeisureArea,
            string userInputForName,
            decimal userInputForValue
        ) : base (userInputForName, userInputForValue)
        {
            EquipmentsNeededInLeisureArea = equipmentsLeisureArea;
            Color = colorLeisureArea;
        }
    }
}

