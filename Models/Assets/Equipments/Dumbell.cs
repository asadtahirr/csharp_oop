using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop.Models.Assets.Equipments
{
    public class Dumbell : GymAsset
    {
        public int Weight { get; set; }
        public string Unit = "kg";
        public string HandleColor { get; set; }

        public Dumbell(int userInputForWeight, string userInputForHandleColor, string userInputForName, decimal userInputForValue, string userInputForStatus) : base(userInputForName, userInputForValue, userInputForStatus)
        {
            Weight = userInputForWeight;
            HandleColor = userInputForHandleColor;
        }
    }

}
