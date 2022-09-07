using System;

namespace csharp_oop.Models.Assets
{
    public class Room : GymAsset
    {
        public int NumberOfRooms { get; set; }
        public string ColorOfRooms { get; set; }

        public virtual Building Building { get; set; }

        public Room(int numberOfRooms, string colorOfRooms, string name, decimal value, string status) : base(name, value, status)
        {
            NumberOfRooms = numberOfRooms;
            ColorOfRooms = colorOfRooms;
        }
    }
}

