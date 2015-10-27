using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PMS3LayerBARD.DAL;

namespace PMS3LayerBARD.BLL
{
    public class LoginBLL
    {
        LoginDAL loginDAL = new LoginDAL();
        public bool Login(string userName, string password)
        {
            return loginDAL.Login(userName, password);

        }
    }
}