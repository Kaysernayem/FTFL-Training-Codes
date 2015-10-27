using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ThreeLayerArchi
{
    public partial class Default : System.Web.UI.Page
    {
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                GetData();
                BindData();
            }
        }

        public void GetData()
        {
            
            EmployeeBussAL EbussAL = new EmployeeBussAL();
            dt = EbussAL.LoadData();
        }

        public void BindData()
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}