using System;
namespace csharp_oop
{
    public class Building : GymAsset
    {
        public string OuterColor { get; set; }
        public string InnerColor { get; set; }
       
        public Building(
            string userInputForOuterColor,
            string userInputForInnerColor,
            string userInputForName,
            decimal userInputForValue
        ) : base(userInputForName, userInputForValue)
        {
            OuterColor = userInputForOuterColor;
            InnerColor = userInputForInnerColor;
        }
    }
}

