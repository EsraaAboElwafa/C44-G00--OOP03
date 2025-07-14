using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    internal class Teacher: Person
    {
        public string Subject { get; set; }
        public Teacher(string firstName, string lastName, int age, string subject)
            : base(firstName, lastName, age)
        {
            Subject = subject;
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $", Subject: {Subject}";
        }
    }
}
