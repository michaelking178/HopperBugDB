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
            return View("ProjectForm");
        }

        public ActionResult Edit(int id)
        {
            var project = _context.Projects.SingleOrDefault(p => p.Id == id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View("ProjectForm", project);
        }

        [HttpPost]
        public ActionResult Save(Project project)
        {
            if (project.Id == 0)
                _context.Projects.Add(project);
            else
            {
                var projectInDb = _context.Projects.Single(p => p.Id == project.Id);
                projectInDb.Name = project.Name;
                projectInDb.Code = project.Code;
            }
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