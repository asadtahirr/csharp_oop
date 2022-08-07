using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    internal class Buterfly :GymAsset
    {
        public string Style1 { get; set; }
        public string Style2 { get; set; }

        public Buterfly (string nameOfAsset, decimal valueOfAsset) : base (nameOfAsset, valueOfAsset)
        {
            Style1 = "Butterfly";
            Style2 = "Shoulder";
        }
    }
}
