using csharp_oop.Models.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop.Models
{
    public enum Shifts
    {
        Day,
        Night
    }

    public class Employee : User
    {
        public string Position { get; set; }
        public string Shift { get; set; }
        public virtual Building Building { get; set; }

        public Employee(string position, string shift, string firstName, string lastName) : base(firstName, lastName)
        {

            Position = position;
            Shift = shift == "day" ? Shifts.Day.ToString() : Shifts.Night.ToString();
        }
    }
}
