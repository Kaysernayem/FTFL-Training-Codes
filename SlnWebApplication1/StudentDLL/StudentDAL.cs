using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using IStudentDAL;

namespace StudentDLL
{
    public class StudentDAL
    {

        public void InsertStudentIntoDB(string connectionString,IStudentDAL.IStudentDataLayer emp)
        {
            
            SqlConnection objSqlConnection = new SqlConnection(connectionString);
            string sqlCommand = "INSERT INTO tblStudent(StudentRollNo,StudentName,StudentAge,StudentAddress,StudentContact,StudentMarks) VALUES(" + Convert.ToInt32(StudentRollNo) + ",'" + Name + "'," + Convert.ToInt32(Age) + ",'" + Address + "'," + Convert.ToInt32(ContactNo) + "," + Convert.ToInt32(StudentMarks) + ")";
            SqlCommand objSqlCommand = new SqlCommand(sqlCommand, objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            //Response.Write("Connect Successfully");
            objSqlConnection.Close();
        }
    }
}
