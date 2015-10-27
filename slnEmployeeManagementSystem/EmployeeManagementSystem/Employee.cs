using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Employee : Person
    {
        private int _employeeId;

        public int EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }
        private string _department;

        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        public Employee(string name, int age, string address, int contactNo, int employeeId, string department):base(name,age,address,contactNo)
        {
            EmployeeId = employeeId;
            Department = department;
        }

        public override string ToString()
        {
            return base.ToString() + "\nEmployee ID=" + EmployeeId + "\nDepartment=" + Department;
        }

        //public void ShowEmployeeDetails()
        //{
        //    base.ShowPersonDetails();
        //    Console.WriteLine("\nEmployee ID=" + EmployeeId + "\nDepartment=" + Department);
        //}

        public override void ShowDetails()
        {
            Console.WriteLine("Name:" + Name + "\nAge:" + Age + "\nAddress:" + Address + "\nContact No:" + ContactNo + "\nEmployee ID=" + EmployeeId + "\nDepartment=" + Department);
        }
    }
}

