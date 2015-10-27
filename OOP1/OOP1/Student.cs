using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Student
    {
        int roll;
        string name;
        float marks;
        char grade;
        public void GetData()
        {
            Console.Write("Enter Name:");
            name = Console.ReadLine();
            Console.Write("Enter Roll no:");
            roll = int.Parse(Console.ReadLine());
            Console.Write("Enter Marks:");
            marks = float.Parse(Console.ReadLine());
            CalGrade();
        }
        public void ShowData()
        {
            Console.WriteLine("Name:"+name+"\tRoll:"+roll+"\tMarks:"+marks+"\tGrade:"+grade);
        }
        private void CalGrade()
        {
            if (marks >= 80)
                grade = 'A';
            else if (marks >= 70)
                grade = 'B';
            else if (marks >= 60)
                grade = 'C';
            else
                grade = 'F';
        }
    }
}
