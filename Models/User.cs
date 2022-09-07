using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop.Models
{
    public abstract class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(string userFirstName, string userLastName)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = userFirstName;
            LastName = userLastName;
        }
    }
}
