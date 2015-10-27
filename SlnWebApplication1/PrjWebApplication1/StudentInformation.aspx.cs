using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmploeeLibrary;
using System.Data.SqlClient;
using System.Configuration;

namespace PrjWebApplication1
{
    public partial class StudentInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Student objStudent = new Student(txtSName.Text, Convert.ToInt32(txtSAge.Text), txtSAddress.Text, Convert.ToInt32(txtSContact.Text), Convert.ToInt32(txtSRollNo.Text), Convert.ToInt32(txtSMarks.Text));
            //objStudent.SavedData(id);
            ////objEmployee.ShowDetails();
            //Response.Write(objStudent.Name + "<br>" + objStudent.Age + "<br>" + objStudent.Address + "<br>" + objStudent.ContactNo + "<br>" + objStudent.StudentRollNo + "<br>" + objStudent.StudentMarks + "<br>");
            //Response.Write(objStudent);

            //string connectionString = "Data Source=KAYSER;Integrated Security=True";
            
            
            //SqlConnection objSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            //string sqlCommand = "INSERT INTO tblStudent(StudentRollNo,StudentName,StudentAge,StudentAddress,StudentContact,StudentMarks) VALUES(" + Convert.ToInt32(txtSRollNo.Text) + ",'" + txtSName.Text + "'," + Convert.ToInt32(txtSAge.Text) + ",'" + txtSAddress.Text + "'," + Convert.ToInt32(txtSContact.Text) + "," + Convert.ToInt32(txtSMarks.Text) + ")";
            //SqlCommand objSqlCommand = new SqlCommand(sqlCommand, objSqlConnection);
            //objSqlConnection.Open();
            //objSqlCommand.ExecuteNonQuery();
            //Response.Write("Connect Successfully");
            //objSqlConnection.Close();

            Student objStudent = new Student(txtSName.Text, Convert.ToInt32(txtSAge.Text), txtSAddress.Text, Convert.ToInt32(txtSContact.Text), Convert.ToInt32(txtSRollNo.Text), Convert.ToInt32(txtSMarks.Text));
            objStudent.AddEmployeeToDB(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }
    }
}