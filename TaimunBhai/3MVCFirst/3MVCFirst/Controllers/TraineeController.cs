using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3MVCFirst.Controllers
{
    public class TraineeController : Controller
    {
        public ActionResult Greetings(String name)
        {
            ViewBag.Message = name;
            return View();
            //return name + "! Hello world from Greetings Controller. Email:"+email;
        }

	}
}