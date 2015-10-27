using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeProject7Days.DataAccessLayer;

namespace CodeProject7Days.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesDAL = new SalesERPDAL();
            return salesDAL.Employees.ToList();
        }
    }
}