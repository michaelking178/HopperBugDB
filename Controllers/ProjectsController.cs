using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hopper.Models;

namespace Hopper.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult Index()
        {
            return View(GetProjects());
        }

        public ActionResult Details(int id)
        {
            var project = GetProjects().SingleOrDefault(proj => proj.Id == id);

            return View(project);
        }

        private IEnumerable<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project { Name = "Hopper Development", Id = 1 },
                new Project { Name = "Vidly Course", Id = 2 }
            };
        }
    }
}