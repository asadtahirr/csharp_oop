using System;
namespace csharp_oop
{
    public class Room : GymAsset
    {
        public int NumberOfRooms { get; set; }
        public string ColorOfRooms { get; set; }


        public Room(int roomsQuantity, string roomsColor,string nameOfAsset, decimal valueOfAsset) : base (nameOfAsset, valueOfAsset)
        {
            NumberOfRooms = roomsQuantity;
            ColorOfRooms = roomsColor;
        }
    }
}

