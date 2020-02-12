using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hopper.Models;

namespace Hopper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(GetProjects());
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

        private IEnumerable<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project { Name = "Hopper Development" },
                new Project { Name = "Vidly Course" }
            };
        }
    }
}