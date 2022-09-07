using System;

namespace csharp_oop.Models.Assets
{
    public class LockerRoom : GymAsset
    {
        public int NumberOfLocks { get; set; }
        public string ColorofLockers { get; set; }
        public string ColorofLockerRoom { get; set; }

        public LockerRoom(int QuantityOflocks, string LockersColor, string LockerRoomColor, string nameOfAsset, decimal valueOfAsset, string userInputForStatus) : base(nameOfAsset, valueOfAsset, userInputForStatus)
        {
            NumberOfLocks = QuantityOflocks;
            ColorofLockers = LockersColor;
            ColorofLockerRoom = LockerRoomColor;
        }
    }
}

