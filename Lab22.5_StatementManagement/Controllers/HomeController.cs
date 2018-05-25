using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab22._5_StatementManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            if (Session["Counter"] == null)
            {
                Session.Add("Counter", 0);

            }
            int visits = (int)Session["Counter"];
            visits++;

            Session["Counter"] = visits;

            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return View();
        }

       

            public ActionResult Login
            (string userName = "Anyname", string colorChoice = "Gold", string passWord1 = "password")
        {
            //ActionResults
            ViewBag.UserName = userName;
            ViewBag.ColorChoice = colorChoice;
            ViewBag.Password1 = passWord1;
            
            return View();
        }
    }
}