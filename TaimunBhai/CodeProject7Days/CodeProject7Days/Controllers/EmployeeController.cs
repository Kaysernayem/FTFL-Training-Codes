using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeProject7Days.Models;
using CodeProject7Days.ViewModels;

namespace CodeProject7Days.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

    EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
    List<Employee>employees = empBal.GetEmployees();

    List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

    foreach (Employee emp in employees)
    {
        EmployeeViewModel empViewModel = new EmployeeViewModel();
        empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
        empViewModel.Salary = emp.Salary.ToString("C");
        if (emp.Salary > 15000)
        {
            empViewModel.SalaryColor = "yellow";
        }
        else
        {
            empViewModel.SalaryColor = "green";
        }
        empViewModels.Add(empViewModel);
    }
    employeeListViewModel.Employees = empViewModels;
    return View(employeeListViewModel);
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        public string SaveEmployee(Employee e)
        {
            return e.FirstName + "|" + e.LastName + "|" + e.Salary;
        }
    }
         
}