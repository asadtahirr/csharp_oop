using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    internal class Television : GymAsset
    {
        public string Channel1 { get; set; }
        public string Channel2 { get; set; }
        public Television(string nameOfAsset, decimal valueOfAsset) : base(nameOfAsset, valueOfAsset)
        {
            Channel1 = "MusicTv";
            Channel2 = "FunSongs";
        }
    }
}
