using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartMVC.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string EmpJob { get; set; }
        public float EmpSalary { get; set; }
        public int EmpDept { get; set; }

        public Employee(int No, string Name,string Job,float Salary,int Dept)
        {
            EmpNo = No;
            EmpName = Name;
            EmpJob = Job;
            EmpSalary = Salary;
            EmpDept = Dept;
        }
    }

    
}