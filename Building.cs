using System;
namespace csharp_oop
{
    public class Building : GymAsset
    {
        public string OuterColor { get; set; }
        public string InnerColor { get; set; }

        public SecurityDoor SecureEntrance { get; set; }
        public LeisureArea LeisureSpot { get; set; }
        public LockerRoom SafeEquipments { get; set; }
        public ReceptionArea EntryPoint { get; set; }

        public PunchingBag TypeBag { get; set; }

        public LegStretch RoomOfLegStretch { get; set; }


        public List<Washroom> Washrooms { get; set; }
        public List<Room> Rooms { get; set; }
       
        public Building(
            string userInputForOuterColor,
            string userInputForInnerColor,
            string userInputForName,
            decimal userInputForValue
        ) : base(userInputForName, userInputForValue)
        {
            OuterColor = userInputForOuterColor;
            InnerColor = userInputForInnerColor;

            TypeBag = new PunchingBag("sand","Black","BoxingBag",1829);

            RoomOfLegStretch = new LegStretch("R32",32);

            SecureEntrance = new SecurityDoor(2, "Standard","Entry",1);

            LeisureSpot = new LeisureArea("ball", "Black", "Name", 1999);

            EntryPoint = new ReceptionArea("bat","theme","Arena",1122);

            SafeEquipments = new LockerRoom(121,"Black","White","FirstRoom",89);
            
            Washroom mensWashroom = new Washroom(5,"Blue","MensWashroom",2);
            Washroom femaleWashroom = new Washroom(6, "Red","FemaleWashroom",8);
            
            Washrooms = new List<Washroom>() { mensWashroom };

            Washrooms.Add(femaleWashroom);

            Washrooms.Add(new Washroom(1, "White","accessible",2));

            Room treadmillRoom = new Room(8,"Purple","Treadmills",100);
            Room stairCaseRoom = new Room(10, "Orange","Staircase",500);
            Room weightRoom = new Room(18, "Mango","weightRoom",1000);
            
            Rooms = new List<Room>() { treadmillRoom };
            Rooms.Add(stairCaseRoom);
            Rooms.Add(weightRoom);
        }
    }
}

