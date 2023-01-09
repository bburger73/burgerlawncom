using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace burgerlawncom.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult ClientManager()
        {
            ViewBag.Message = "Client Manager";
            return View();
        }
        public ActionResult ClientServices()
        {
            ViewBag.Message = "Client Services";
            return View();
        }
        public ActionResult ClientTimer()
        {
            ViewBag.Message = "Client Timer";
            return View();
        }
        public ActionResult Dashboard()
        {
            ViewBag.Message = "User";
            return View();
        }
        public ActionResult Forgot()
        {
            ViewBag.Message = "Forgot";
            return View();
        }
        public ActionResult ServiceManager()
        {
            ViewBag.Message = "Service Manager";
            return View();
        }
        public ActionResult SignIn()
        {
            ViewBag.Message = "Sign In";
            return View();
        }
        public ActionResult SignUp()
        {
            ViewBag.Message = "Sign Up";
            return View();
        }
    }
}