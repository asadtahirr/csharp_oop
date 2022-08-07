using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    internal class Dumbell
    {
        public int Weight { get; set; }
        public string Unit = "kg";
        public string HandleColor { get; set; }

        public Dumbell(int userInputForWeight, string userInputForHandleColor)
        {
            Weight = userInputForWeight;
            HandleColor = userInputForHandleColor;
        }
    }

}
