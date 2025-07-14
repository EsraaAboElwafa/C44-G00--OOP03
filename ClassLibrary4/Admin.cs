using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    internal class Admin: Person
    {
        public string Role { get; set; }

        public Admin(string firstName, string lastName, int age, string role)
            : base(firstName, lastName, age)
        {
            Role = role;
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $", Role: {Role}";
        }
    }
}
