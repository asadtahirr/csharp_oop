using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    public abstract class GymAsset

    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public GymAsset(string nameOfAsset, decimal valueOfAsset)
        {
            Id = Guid.NewGuid().ToString();
            Name = nameOfAsset;
            Value = valueOfAsset;
        }
    }
}
