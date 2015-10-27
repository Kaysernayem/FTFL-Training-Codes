using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace LabExam
{
    public partial class NewRegistration : System.Web.UI.Page
    {
        SqlConnection con=new SqlConnection("Data Source=POLO_DEV_PC\\SQLEXPRESS;Initial Catalog=PFMSDB;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtName.Text=txtUserID.Text = TxtPassword.Text=TxtConfirmPassword.Text="";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int uid=int.Parse(txtUserID.Text);
            string name=txtName.Text;
            string password=TxtPassword.Text;
            string gender=RadioButtonList1.SelectedValue;
            string track=DDTrack.SelectedValue;
            SqlCommand cmd=new SqlCommand("INSERT into UserAccount (UserID,Name,Password,Gender,Track) values (@uid,@name,@password,@gender,@track)",con);
            cmd.Parameters.AddWithValue("@uid",uid);
            cmd.Parameters.AddWithValue("@name",name);
            cmd.Parameters.AddWithValue("@password",password);
            cmd.Parameters.AddWithValue("@gender",gender);
            cmd.Parameters.AddWithValue("@track",track);

            con.Open();
            cmd.ExecuteNonQuery();
            Label1.Text="Successfully Inserted";
            con.Close();
        }
    }
}