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

        public Employee(string positionOfEmployee, bool isWorkingDayShift, string userFirstName, string userLastName) : base(userFirstName, userLastName)
        {

            Position = positionOfEmployee;
            Shift = isWorkingDayShift ? Shifts.Day.ToString() : Shifts.Night.ToString();
        }
    }
}
