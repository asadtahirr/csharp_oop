using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop.Models.Assets
{
    public interface Asset
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
