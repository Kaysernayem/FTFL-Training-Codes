using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateSample
{
    public delegate bool IsPassed(Student stu);
    public class Student
    {
        public int SId { get; set; }
        public string SName { get; set; }
        public int SAge { get; set; }
        public string SDepartment { get; set; }
        public int SMarks { get; set; }

        public static void resultStudent(List<Student> listStudent, IsPassed delPassed)
        {
            foreach (Student stu in listStudent)
            {
                if (delPassed(stu))
                {
                    Console.WriteLine("Congratulation !!! {0} you are Passed!", stu.SName);
                }
            }
        }
    }
}
