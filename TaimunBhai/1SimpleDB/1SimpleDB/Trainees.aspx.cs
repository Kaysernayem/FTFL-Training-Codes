using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace _1SimpleDB
{
    public partial class Trainees : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=POLO_DEV_PC\\SQLEXPRESS;Initial Catalog=FTFLDB;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select count(*) from tableTrainee", con);
            int n = 0;
            con.Open();
            n = (int)cmd.ExecuteScalar();
            totalTraineeLabel.Text = n.ToString();

            //SqlCommand command = new SqlCommand("Select * from tableTrainee", con);
            //SqlDataReader dr;
            //dr = command.ExecuteReader();
            //GridView1.DataSource = dr;
            //GridView1.DataBind();

            con.Close();
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string s = SearchTextBox.Text;
            SqlCommand cmd = new SqlCommand("Select * from tableTrainee where Name Like  '%" + s + "%'", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();

            con.Close();


        }
        
    }
}