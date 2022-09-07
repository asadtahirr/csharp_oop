using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop.Models.Assets
{
    internal class Buterfly : GymAsset
    {
        public string Style1 { get; set; }
        public string Style2 { get; set; }

        public Buterfly(string nameOfAsset, decimal valueOfAsset, string userInputForStatus) : base(nameOfAsset, valueOfAsset, userInputForStatus)
        {
            Style1 = "Butterfly";
            Style2 = "Shoulder";
        }
    }
}
