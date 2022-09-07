using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop.Models.Assets
{
    public class PunchingBag : GymAsset
    {

        public string Stuff1 { get; set; }
        public string Stuff2 { get; set; }
        public PunchingBag(string TypeOfStuff, string ColorOfBag, string userInputForName, decimal userInputForValue, string userInputForStatus
        ) : base(userInputForName, userInputForValue, userInputForStatus)
        {
            Stuff1 = TypeOfStuff;
            Stuff2 = ColorOfBag;

        }
    }

}
