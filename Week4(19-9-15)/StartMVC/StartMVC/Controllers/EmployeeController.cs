using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StartMVC.Models;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace StartMVC.Controllers
{
    public class EmployeeController : Controller
    {
        SqlConnection conn = new SqlConnection("Data Source=Kayser;Initial Catalog=FTFLPractice;Integrated Security=True");
        //
        // GET: /Employee/
        public ActionResult Show()
        {
            SqlCommand cmd = new SqlCommand("Select EMPNO,ENAME,JOB,SALARY,DEPTNO from Employee", conn);
            SqlDataReader dr;
            conn.Open();
            ArrayList a = new ArrayList();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                int empno = int.Parse(dr.GetValue(0).ToString());
                string empname = dr.GetValue(1).ToString();
                string empdesi = dr.GetValue(2).ToString();
                float empsal = float.Parse(dr.GetValue(3).ToString());
                int empdept = int.Parse(dr.GetValue(4).ToString());
                Employee e = new Employee(empno, empname, empdesi, empsal, empdept);
                a.Add(e);
            }
            ViewBag.Data = a;
            ViewBag.Title = "First MVC Project";
            conn.Close();
            return View();
        }

        public ActionResult AddEmployee()
    {

        return View();
    }
	}
}