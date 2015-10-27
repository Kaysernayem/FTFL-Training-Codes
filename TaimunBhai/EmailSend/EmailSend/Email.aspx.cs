using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;


namespace EmailSend
{
    public partial class Email : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var fromAddress = new MailAddress("pfms1971@gmail.com", "FTFL Training");
                var toAddress = new MailAddress("kayserbhuiyan@gmail.com", "To Name");
                const string fromPassword = "pfms12345";
                const string subject = "New Request for Training";
                const string body = "Dear Sir,/n Hope you are doing well";
                //Label1.Text = "Wait for a moment....";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                    Label1.Text = "Successfully Sent";
                }



            }
            catch (Exception e1)
            {
                Label1.Text = "Problem" + e1.ToString();
                throw;
            }
        }
    }
}