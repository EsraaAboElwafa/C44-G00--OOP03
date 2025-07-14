using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    internal class Student: Person
    {
        public string GradeLevel { get; set; }

        public Student(string firstName, string lastName, int age, string gradeLevel): base(firstName, lastName, age)
        {
            GradeLevel = gradeLevel;
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $", Grade Level: {GradeLevel}";
        }
    }
}
