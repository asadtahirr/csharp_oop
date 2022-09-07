using System;

namespace csharp_oop.Models.Assets.Equipments
{
    public class Washroom : GymAsset
    {
        public int Toilets { get; set; }
        public string Theme { get; set; }

        public virtual Building Building { get; set; }

        public Washroom(int toilets, string theme, string name, decimal value, string status) : base(name, value, status)
        {
            Toilets = toilets;
            Theme = theme;
        }

    }
}

