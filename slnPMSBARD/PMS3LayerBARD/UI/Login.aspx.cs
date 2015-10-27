using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PMS3LayerBARD.BLL;

namespace PMS3LayerBARD.UI
{

    public partial class Login : System.Web.UI.Page
    {
        LoginBLL loginBLL = new LoginBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = UserNamTextBox.Text;
            string password = PassTextBox.Text;
            if (loginBLL.Login(userName, password))
            {
                Session["UserName"] = userName;
                Session["Password"] = password;
                Response.Redirect("Home.aspx");
            }
            else
                errorLabel.Text = "User Name or password is invalid !";
        }
    }
}