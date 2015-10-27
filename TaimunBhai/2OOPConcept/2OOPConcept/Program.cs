using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2OOPConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Kayser", "Ahmed","Nayem");
            string fullName = student1.GetFullName();

            Student student2 = new Student();
            student2.FirstName = "Shmal";
            string fName = student2.FirstName;
            student2.MiddleName = "Chandra";
            student2.LastName = "Das";
            fullName = student2.GetFullName();

            Student student3 = new Student();
            student3.FirstName = "Abdullah";
            student3.MiddleName = "Al";
            student3.LastName = "Nahiyan";
            fullName = student3.GetFullName();

            student2.FirstName = "Shamal";

            List<Student> studentList=new List<Student>()
                studentList.Add(student1);
                studentList.Add(student2);
                studentList.Add(student3);

            foreach (Student aStudent in studentList)
	{
		 Console.WriteLine(aStudent);
	}
        }
    }
}
