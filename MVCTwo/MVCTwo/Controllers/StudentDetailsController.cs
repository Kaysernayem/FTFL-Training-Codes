using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTwo.Models;
using System.Data.SqlClient;

namespace MVCTwo.Controllers
{
    public class StudentDetailsController : Controller
    {
        //
        // GET: /StudentDetails/
        public ActionResult Index()
        {
            StudentListModel obmodel = new StudentListModel();
            obmodel.StudentListCollection = new List<StudentList>();
            obmodel.StudentListCollection = GetStudentList();
            return View(obmodel);
        }

        public List<StudentList> GetStudentList()
        {
            List<StudentList> s=new List<StudentList>();
            SqlConnection con = new SqlConnection("Data Source=POLO_DEV_PC\\SQLEXPRESS;Initial Catalog=PFMSDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from StudentDetail", con);
            SqlDataReader dr;
            con.Open();
            dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                StudentList stud = new StudentList();
                stud.Id = dr.GetValue(0).ToString();
                stud.Name = dr.GetValue(1).ToString();
                stud.Address = dr.GetValue(2).ToString();
                stud.Section = dr.GetValue(3).ToString();
                stud.Marks = int.Parse(dr.GetValue(4).ToString());
                s.Add(stud);
            }
            con.Close();
            return s;
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection c)
        {
            StudentList s = new StudentList();
            s.Id = c["id1"].ToString();
            s.Name = c["name1"].ToString();
            s.Address = c["address1"].ToString();
            s.Section = c["section1"].ToString();
            s.Marks = int.Parse(c["marks1"].ToString());
            if (SaveData(s))
            {
                ViewBag.Msg = "Successfully Added";
            }
            else
                ViewBag.Msg = "Error";
            return View();
        }

        public bool SaveData(StudentList st)
        {
            SqlConnection con = new SqlConnection("Data Source=POLO_DEV_PC\\SQLEXPRESS;Initial Catalog=PFMSDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Insert into StudentDetail (id,name,address,section,marks) Values(@id,@name,@address,@section,@marks) ", con);
            cmd.Parameters.AddWithValue("@id",st.Id);
            cmd.Parameters.AddWithValue("@name", st.Name);
            cmd.Parameters.AddWithValue("@address", st.Address);
            cmd.Parameters.AddWithValue("@section", st.Section);
            cmd.Parameters.AddWithValue("@marks", st.Marks);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(FormCollection c)
        {
            if(c["show"]!=null)
            {
                string id = c["id1"].ToString();
                StudentList s = ShowData(id);
                if (s.Id != null)
                {
                    ViewBag.id = s.Id;
                    ViewBag.name = s.Name;
                    ViewBag.address = s.Address;
                    ViewBag.section = s.Section;
                    ViewBag.marks = s.Marks;
                    ViewBag.Msg = "Found";
                }
                    
                else
                    ViewBag.Msg = "Not Found";
            }

            else if (c["update"] != null)
            {
                string id = c["id1"].ToString();
                int mks = int.Parse(c["marks1"].ToString());
                if (UpdateMarks(id, mks))
                    ViewBag.Msg = "Updated Successfully";
                else
                    ViewBag.Msg = "Error";
            }
                return View();
        }

        public StudentList ShowData(string id)
        {
            StudentList s = new StudentList();
            SqlConnection con = new SqlConnection("Data Source=POLO_DEV_PC\\SQLEXPRESS;Initial Catalog=PFMSDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select id,name,address,section,marks from StudentDetail where id=@id ", con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                s.Id = dr.GetValue(0).ToString();
                s.Name = dr.GetValue(1).ToString();
                s.Address = dr.GetValue(2).ToString();
                s.Section = dr.GetValue(3).ToString();
                s.Marks = int.Parse(dr.GetValue(4).ToString());
            }
            con.Close();
            return s;
        }

        public bool UpdateMarks(string id, int marks)
        {
            SqlConnection con = new SqlConnection("Data Source=POLO_DEV_PC\\SQLEXPRESS;Initial Catalog=PFMSDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Update StudentDetail set marks=@marks where id=@id ", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@marks", marks);
            con.Open();
            int n=cmd.ExecuteNonQuery();
            con.Close();
            if (n > 0)
                return true;
            else
                return false;
        }
	}
}