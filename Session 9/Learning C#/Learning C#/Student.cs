using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Birthday { get; set;}

        public Student(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName= lastName;
        }
        public string Getfullname(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

    }
}
