using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2OOPConcept
{
    class Student
    {
        private string firstName;
        private string middleMane;
        private string lastName;

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleMane;
            LastName = lastName;
        }

        public string GetFullName()
        {
            string fullName = FirstName + " " + MiddleName + " " + LastName;
            return fullName;
        }
    }
}
