using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace DemoEnc
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string un = TextBox1.Text;
            string pw = TextBox2.Text;
            SqlConnection con = new SqlConnection("Data Source=POLO_DEV_PC\\SQLEXPRESS;Initial Catalog=PhysicalFacilitiesDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Insert into user1 values(@UN,convert(varbinary(50),EncryptByPassPhrase(@PW, @UN )))", con);
            con.Open();
            cmd.Parameters.AddWithValue("@UN", un);
            cmd.Parameters.AddWithValue("@PW", pw);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=POLO_DEV_PC\\SQLEXPRESS;Initial Catalog=PhysicalFacilitiesDB;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand("select convert(varchar(50),DecryptByPassPhrase(username, password )) from user1 where uid='@UN'", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = dr.GetValue(0).ToString();

            }
            con.Close();
            //SqlConnection con = new SqlConnection("Data Source=POLO_DEV_PC\\SQLEXPRESS;Initial Catalog=PhysicalFacilitiesDB;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("select * from user1", con);
            //SqlDataReader dr;
            //con.Open();
            //dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    GridView1.DataSource=dr;
            //    GridView1.DataBind();
            //}
            //con.Close();
        }
    }
}