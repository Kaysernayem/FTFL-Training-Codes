using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Student:Person
    {
        private int _StudentRollNo;

        public int StudentRollNo
        {
            get { return _StudentRollNo; }
            set { _StudentRollNo = value; }
        }
        private int _StudentMarks;

        public int StudentMarks
        {
            get { return _StudentMarks; }
            set { _StudentMarks = value; }
        }

        public Student(string name, int age, string address, int contactNo, int studentROllNo,int studentMarks):base(name,age,address,contactNo)
        {
            _StudentRollNo = studentROllNo;
            _StudentMarks = studentMarks;
        }

        //public void ShowStudentDetails()
        //{
        //    base.ShowPersonDetails();
        //    Console.WriteLine("\nStudent Roll No:" + StudentRollNo + "\nStudent Marks:" + StudentMarks);
        //}

        public override void ShowDetails()
        {
            Console.WriteLine("Name:" + Name + "\nAge:" + Age + "\nAddress:" + Address + "\nContact No:" + ContactNo + "\nStudent Roll No:" + StudentRollNo + "\nStudent Marks:" + StudentMarks);
        }

        public override string ToString()
        {
            return base.ToString()+"\nStudent Roll No:" + StudentRollNo + "\nStudent Marks:" + StudentMarks;
        }
    }
}
