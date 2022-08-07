using System;
namespace csharp_oop
{
    public class SecurityDoor : GymAsset
    {

        public int NumberOfDoors { get; set; }
        public string SecurityLevel { get; set; }


        public SecurityDoor(int DoorsQuantity, string LevelOfsecirity, string nameOfAsset, decimal valueOfAsset) : base(nameOfAsset, valueOfAsset)
        {
            NumberOfDoors = DoorsQuantity;
            SecurityLevel = LevelOfsecirity;
        }
    }
}

