using System;
using csharp_oop.Models.Assets.Equipments;

namespace csharp_oop.Models.Assets
{
    public class Building : GymAsset
    {
        public string OuterColor { get; set; }
        public string InnerColor { get; set; }
        
        public virtual List<Employee> Employees { get; set; }
        public virtual List<Customer> Customers { get; set; }

         // public SecurityDoor SecureEntrance { get; set; }
         // public LeisureArea LeisureSpot { get; set; }
         // public LockerRoom SafeEquipments { get; set; }
         // public ReceptionArea EntryPoint { get; set; }

         // public PunchingBag TypeBag { get; set; }

         // public LegStretch RoomOfLegStretch { get; set; }
         public virtual List<Room> Rooms { get; set; }
         public virtual List<Washroom> Washrooms { get; set; }

        public Building(
            string outerColor,
            string innerColor,
            string name,
            decimal value,
            string status
        ) : base(name, value, status)
        {
            OuterColor = outerColor;

            InnerColor = innerColor;

            Rooms = new List<Room>();

            Washrooms = new List<Washroom>();

            Employees = new List<Employee>();

            Customers = new List<Customer>();

        }
    }
}

