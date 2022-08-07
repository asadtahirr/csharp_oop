using System;
namespace csharp_oop
{
    public class LockerRoom : GymAsset
    {
        public int NumberOfLocks { get; set; }
        public string ColorofLockers{ get; set; }
        public string ColorofLockerRoom { get; set; }

        public LockerRoom(int QuantityOflocks, string LockersColor, string LockerRoomColor,string nameOfAsset, decimal valueOfAsset) : base (nameOfAsset, valueOfAsset)
        {
            NumberOfLocks = QuantityOflocks;
            ColorofLockers = LockersColor;
            ColorofLockerRoom = LockerRoomColor;
        }
    }
}

