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
    public partial class EntryTrainee : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=POLO_DEV_PC\\SQLEXPRESS;Initial Catalog=FTFLDB;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string id = Request.Form["Id"];
                string name = Request.Form["Name"];
                string email = Request.Form["Email"];
                string contact = Request.Form["Contact"];
                string address = Request.Form["Address"];

                SqlCommand cmd = new SqlCommand("Insert into tableTrainee (id,name,email,contact,address) values (@Id,@Name,@Email,@Contact,@Address)", con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.Parameters.AddWithValue("@Address", address);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            
        }
    }
}