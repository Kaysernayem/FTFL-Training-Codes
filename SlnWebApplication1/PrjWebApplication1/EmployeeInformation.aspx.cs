using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmploeeLibrary;
using System.Data.SqlClient;

namespace PrjWebApplication1
{
    public partial class EmployeeInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Response.Write("Employee Name:"+txtName.Text);
            //Response.Write("<br>Employee Age:" + txtAge.Text);
            //Response.Write("<br>Employee Address:" + txtAddress.Text);
            //Response.Write("<br>Employee Contact No:" + txtContact.Text);
            //Response.Write("<br>Employee ID:" + txtID.Text);
            //Response.Write("<br>Employee Department:" + txtDepartment.Text);

            //Employee objEmployee = new Employee(txtName.Text, Convert.ToInt32(txtAge.Text), txtAddress.Text, Convert.ToInt32(txtContact.Text), Convert.ToInt32(txtID.Text), txtDepartment.Text);
            ////objEmployee.ShowDetails();
            //Response.Write(objEmployee.Name + "<br>" + objEmployee.Age + "<br>" + objEmployee.Address + "<br>" + objEmployee.ContactNo + "<br>" + objEmployee.EmployeeId + "<br>" + objEmployee.Department + "<br>");
            //Response.Write(objEmployee);

            SqlConnection conn = new SqlConnection("Data Source=KAYSER;Integrated Security=True");
            SqlCommand insert = new SqlCommand("INSERT INTO tblEmployee(EmployeeId, EmployeeName, EmployeeAge,EmployeeAddress,EmployeeContact,EmployeeDepartment) values(@EId,@EName,@EAge,@EAddress,@EContact, @EDepartment)", conn);
            insert.Parameters.AddWithValue("@EId", txtID.Text);
            insert.Parameters.AddWithValue("@EName", txtName.Text);
            insert.Parameters.AddWithValue("@EAge", txtAge.Text);
            insert.Parameters.AddWithValue("@EAddress", txtAddress.Text);
            insert.Parameters.AddWithValue("@EContact", txtContact.Text);
            insert.Parameters.AddWithValue("@EDepartment", txtDepartment.Text);
            try
            {
                conn.Open();
                insert.ExecuteNonQuery();
            }
            catch
            {
                Response.Write("Error when saving on database");
                conn.Close();
            }
            Response.Write("Saved Successfully");
        }
        protected void btnShowData_Click(object sender, EventArgs e)
        { 
        }
    }
}