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
            project.Bugs = GetBugs(project);

            return View(project);
        }

        private IEnumerable<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project { Id = 1, Name = "Hopper Development", Code = "HOPP"},
                new Project { Id = 2, Name = "Vidly Course", Code = "VIDL" }
            };
        } // For testing only

        private List<Bug> GetBugs(Project proj)
        {
            return new List<Bug>
            {
                new Bug(proj, 1)
                {
                    Project = proj,
                    ReportedBy = "Michael King",
                    Assignee = "Michael King",
                    Status = "New",
                    Priority = "High",
                    Summary = "Hopper does not include SQL databases for storing bugs and projects",
                    ActualResult = "Data is not persistent and must be hardcoded for testing.",
                    ExpectedResult = "Data is persisent and can be dynamically changed and updated.",
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now
                },
                new Bug(proj, 2)
                {
                    Project = proj,
                    ReportedBy = "Michael King",
                    Assignee = "Michael King",
                    Status = "New",
                    Priority = "High",
                    Summary = "Hopper does not include SQL databases for storing bugs and projects",
                    ActualResult = "Data is not persistent and must be hardcoded for testing.",
                    ExpectedResult = "Data is persisent and can be dynamically changed and updated.",
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now
                }
            };
        } // For testing only
    }
}