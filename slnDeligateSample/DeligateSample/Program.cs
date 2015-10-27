using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateSample
{
    class Program
    {
        //delegate void MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            //MyDelegate objMyDelegate = new MyDelegate(Multi);
            //objMyDelegate(10, 15);
            ////Add(10, 5);

            //IsPromotable p = new IsPromotable(promot);
            List < Employee > objListEmployee= new List<Employee>();
            objListEmployee.Add(new Employee() { Id = 100, Name = "EmpName1", Age = 35, Salary = 3000, YearsOfExp = 5 });
            objListEmployee.Add(new Employee() { Id = 101, Name = "EmpName2", Age = 40, Salary = 4000, YearsOfExp = 7 });
            objListEmployee.Add(new Employee() { Id = 102, Name = "EmpName3", Age = 36, Salary = 3500, YearsOfExp = 4 });
            objListEmployee.Add(new Employee() { Id = 103, Name = "EmpName4", Age = 30, Salary = 3800, YearsOfExp = 2 });
            objListEmployee.Add(new Employee() { Id = 104, Name = "EmpName5", Age = 28, Salary = 5000, YearsOfExp = 5 });
            objListEmployee.Add(new Employee() { Id = 105, Name = "EmpName6", Age = 45, Salary = 6000, YearsOfExp = 8 });

            Employee.PromotEmployee(objListEmployee, emp => emp.Salary >= 3500 && emp.Age>=35); 
            //    Employee.PromotEmployee(objListEmployee,delegate (Employee emp)

        //{
            
        //    if (emp.Salary >= 3000)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //});
        //static void Add(int a, int b)
        //{
        //    int c = a + b;
        //    Console.WriteLine("Result=" + c);
        //    Console.Read();
        //}
        //static void Multi(int a, int b)
        //{
        //    int c = a * b;
        //    Console.WriteLine("Result=" + c);
        //    Console.Read();
        //}

            List<Student> objListStudent = new List<Student>();
            objListStudent.Add(new Student() { SId = 300, SName = "StuName1", SAge = 23, SDepartment = "CSE", SMarks = 67 });
            objListStudent.Add(new Student() { SId = 301, SName = "StuName2", SAge = 24, SDepartment = "ETE", SMarks = 78 });
            objListStudent.Add(new Student() { SId = 302, SName = "StuName3", SAge = 22, SDepartment = "SEO", SMarks = 57});
            objListStudent.Add(new Student() { SId = 303, SName = "StuName4", SAge = 21, SDepartment = "CSE", SMarks = 51});
            objListStudent.Add(new Student() { SId = 304, SName = "StuName5", SAge = 25, SDepartment = "IEE", SMarks = 48});
            objListStudent.Add(new Student() { SId = 305, SName = "StuName6", SAge = 22, SDepartment = "CRO", SMarks = 82});

            Student.resultStudent(objListStudent, stu => stu.SMarks >= 60); 
            Console.Read();
        }
    }
}
