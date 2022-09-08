using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop.Models.Assets
{
    enum Statuses
    {
        Functional,
        Damaged
    }

    public abstract class GymAsset
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public decimal Value { get; set; }

        public GymAsset(string name, decimal value, string status)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Value = value;

            if (status == "functional")
                Status = Statuses.Functional.ToString().ToLower();
            else if (status == "damaged")
                Status = Statuses.Damaged.ToString().ToLower();
            else
                Status = null;
        }
    }
}
