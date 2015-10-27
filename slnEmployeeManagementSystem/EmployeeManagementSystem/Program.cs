using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmploeeLibrary;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int choice;
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine("1. for Student Information");
                Console.WriteLine("2. for Teacher Information");
                Console.WriteLine("0. for Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            string name, address;
                            int age, studentROllNo, studentMarks, contactNo;
                            Console.WriteLine("Enter Student's Name: ");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter Student's Age: ");
                            age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Student's Address: ");
                            address = Console.ReadLine();
                            Console.WriteLine("Enter Student's Contact: ");
                            contactNo = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Student's ID: ");
                            studentROllNo = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Student's Department: ");
                            studentMarks = int.Parse(Console.ReadLine());

                            Student objStudent = new Student(name, age, address, contactNo, studentROllNo, studentMarks);
                            objStudent.ShowDetails();
                            break;
                        }
                    case 2:
                        {
                            string Ename, Eaddress, Edepartment;
                            int Eage, employeeId, Econtact;
                            Console.WriteLine("Enter Employee's Name: ");
                            Ename = Console.ReadLine();
                            Console.WriteLine("Enter Employee's Age: ");
                            Eage = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Employee's Address: ");
                            Eaddress = Console.ReadLine();
                            Console.WriteLine("Enter Employee's Contact: ");
                            Econtact = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Employee's ID: ");
                            employeeId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Employee's Department: ");
                            Edepartment = Console.ReadLine();

                            Employee objEmployee = new Employee(Ename, Eage, Eaddress, Econtact, employeeId, Edepartment);
                            objEmployee.ShowDetails();
                            break;
                        }
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }

                ////Person objPerson = new Person("Lata", 18, "BARD", 1711111111);
                ////Console.WriteLine(objPerson.ToString());

                ////objPerson.ShowPersonDetails();
                ////objPerson.Age = 80;
                ////objPerson.ShowPersonDetails();
                ////Console.WriteLine("The address of objPerson is:" + objPerson.Address);
                ////Console.Read();

                ////Employee objEmployee = new Employee("Kayser", 25, "Dhaka", 1710328545, 0003013, "Training");
                ////Console.WriteLine(objEmployee.ToString());
                ////objEmployee.ShowEmployeeDetails();

                //Student objStudent = new Student("Ahmed", 24, "Feni", 1816234687, 10, 67);
                ////objStudent.ShowStudentDetails();
                //Console.WriteLine(objStudent.ToString());

                Console.Read();
            }
        }
    }
}
