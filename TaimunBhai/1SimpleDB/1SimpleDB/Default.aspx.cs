using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1SimpleDB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void noOfTrainLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Trainees.aspx");
        }

        protected void addTraineeLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("EntryTrainee.aspx");
        }
    }
}