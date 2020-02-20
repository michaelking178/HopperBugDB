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
        private ApplicationDbContext _context;

        public ProjectsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var projects = _context.Projects;
            return View(projects);
        }

        public ActionResult Details(int id)
        {
            var project = _context.Projects.SingleOrDefault(proj => proj.Id == id);
            project.Bugs = GetBugs(project);

            return View(project);
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();

            return RedirectToAction("Index", "Projects");
        }

        private List<Bug> GetBugs(Project proj)
        {
            return new List<Bug>
            {
                new Bug(proj, 1)
                {
                    Project = proj,
                    ReportedBy = "Michael King",
                    Assignee = "Michael King",
                    BugStatus = Bug.Status.New,
                    BugPriority = Bug.Priority.High,
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
                    BugStatus = Bug.Status.New,
                    BugPriority = Bug.Priority.High,
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