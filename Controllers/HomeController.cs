using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hopper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message1 = "A JIRA-like bug database.";
            ViewBag.Message2 = "Inspired by real-world QA.";
            ViewBag.Message3 = "...Who is this guy?";
            ViewBag.Message4 = "Okay. How do we get him?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "I'd like to hear from you.";

            return View();
        }
    }
}