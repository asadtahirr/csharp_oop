using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    public class LegStretch : GymAsset
    {
        public int Power1 { get; set; }
        public int Power2 { get; set; }

        public LegStretch(string nameOfAsset, decimal valueOfAsset) : base(nameOfAsset, valueOfAsset)
        {
            Power1 = 0;
            Power2 = 100;
        }
    }
}
