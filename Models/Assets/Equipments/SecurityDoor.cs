using System;

namespace csharp_oop.Models.Assets
{
    public class SecurityDoor : GymAsset
    {

        public int NumberOfDoors { get; set; }
        public string SecurityLevel { get; set; }


        public SecurityDoor(int DoorsQuantity, string LevelOfsecirity, string nameOfAsset, decimal valueOfAsset, string statusOfAsset) : base(nameOfAsset, valueOfAsset, statusOfAsset)
        {
            NumberOfDoors = DoorsQuantity;
            SecurityLevel = LevelOfsecirity;
        }
    }
}

