using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop.Models.Assets
{
    internal class Desks : GymAsset
    {
        public string Desk1 { get; set; }
        public string Desk2 { get; set; }

        public Desks(string nameOfAsset, decimal valueOfAsset, string userInputForStatus) : base(nameOfAsset, valueOfAsset, userInputForStatus)
        {
            Desk1 = "Table";
            Desk2 = "RoundTable";

        }
    }
}
