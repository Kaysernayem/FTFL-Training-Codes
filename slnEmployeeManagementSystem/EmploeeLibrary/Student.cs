using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using IStudentDAL;
using StudentDLL;

namespace EmploeeLibrary
{
    public class Student:Person, IStudentDAL.IStudentDataLayer
    {
        private int _StudentRollNo;

        public int StudentRollNo
        {
            get { return _StudentRollNo; }
            set { _StudentRollNo = value; }
        }
        private int _StudentMarks;

        public int StudentMarks
        {
            get { return _StudentMarks; }
            set { _StudentMarks = value; }
        }

        public Student(string name, int age, string address, int contactNo, int studentROllNo, int studentMarks)
            : base(name, age, address, contactNo)
        {
            _StudentRollNo = studentROllNo;
            _StudentMarks = studentMarks;
        }

        //public void ShowStudentDetails()
        //{
        //    base.ShowPersonDetails();
        //    Console.WriteLine("\nStudent Roll No:" + StudentRollNo + "\nStudent Marks:" + StudentMarks);
        //}

        public override void ShowDetails()
        {
            Console.WriteLine("Name:" + Name + "\nAge:" + Age + "\nAddress:" + Address + "\nContact No:" + ContactNo + "\nStudent Roll No:" + StudentRollNo + "\nStudent Marks:" + StudentMarks);
        }

        public override string ToString()
        {
            return base.ToString() + "\nStudent Roll No:" + StudentRollNo + "\nStudent Marks:" + StudentMarks;
        }

        public void AddEmployeeToDB(string connectionString)
        {
            StudentDLL.StudentDAL sda = new StudentDLL.StudentDAL();
            sda.InsertStudentIntoDB(connectionString, this);
            //SqlConnection objSqlConnection = new SqlConnection(connectionString);
            //string sqlCommand = "INSERT INTO tblStudent(StudentRollNo,StudentName,StudentAge,StudentAddress,StudentContact,StudentMarks) VALUES(" + Convert.ToInt32(StudentRollNo) + ",'" + Name + "'," + Convert.ToInt32(Age) + ",'" + Address + "'," + Convert.ToInt32(ContactNo) + "," + Convert.ToInt32(StudentMarks) + ")";
            //SqlCommand objSqlCommand = new SqlCommand(sqlCommand, objSqlConnection);
            //objSqlConnection.Open();
            //objSqlCommand.ExecuteNonQuery();
            ////Response.Write("Connect Successfully");
            //objSqlConnection.Close();
        }
    }
}
