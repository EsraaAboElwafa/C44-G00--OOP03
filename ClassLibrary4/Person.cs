using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    internal class Person
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private int age { get; set; }
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public virtual string GetDetails()
        {
            return $"Name: {firstName} {lastName}, Age: {age}";
        }
    }
}
