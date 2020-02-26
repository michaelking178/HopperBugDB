using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hopper.Models;
using Hopper.ViewModels;

namespace Hopper.Controllers
{
    public class BugsController : Controller
    {
        private ApplicationDbContext _context;

        public BugsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index(string issueId)
        {
            if (issueId == null)
                return RedirectToAction("Index", "Projects");
            else
            {
                var issue = _context.Bugs.SingleOrDefault(b => b.IssueId == issueId);
                return View(issue);
            }
        }

        public ActionResult New(int id)
        {
            var project = _context.Projects.SingleOrDefault(p => p.Id == id);

            if (project == null)
                return HttpNotFound();
            else
            {
                var viewModel = new BugFormViewModel
                {
                    Project = project
                };
                return View("BugsForm", viewModel);
            }
        }

        //public ActionResult Edit(int id)
        //{
        //    var project = _context.Projects.SingleOrDefault(p => p.Id == id);

        //    if (project == null)
        //        return HttpNotFound();
        //    else
        //    {
        //        var viewModel = new BugFormViewModel
        //        {
        //            Project = project
        //        };
        //        return View("BugsForm", viewModel);
        //    }
        //}

        [HttpPost]
        public ActionResult Save(BugFormViewModel viewModel)
        {
            var bug = viewModel.Bug;
            var project = _context.Projects.SingleOrDefault(p => p.Id == viewModel.Project.Id);

            // Creating a new bug
            if (bug.Id == 0)
            {
                bug.Project = project;
                bug.UpdatedOn = DateTime.Now;

                _context.Bugs.Add(bug);
                _context.SaveChanges();

                var projectCode = project.Code;
                var issueId = projectCode + "-" + bug.Id.ToString("D4");
                bug.IssueId = issueId;
            }
            // Editing an existing bug
            else
            {
                var bugInDb = _context.Bugs.Single(b => b.Id == bug.Id);

                bugInDb.ReportedBy = bug.ReportedBy;
                bugInDb.Assignee = bug.Assignee;
                bugInDb.IssueStatus = bug.IssueStatus;
                bugInDb.IssuePriority = bug.IssuePriority;
                bugInDb.Summary = bug.Summary;
                bugInDb.CreatedOn = bug.CreatedOn;
                bugInDb.UpdatedOn = DateTime.Now;
                bugInDb.Comments = bug.Comments;
                bugInDb.StepsToReproduce = bug.StepsToReproduce;
                bugInDb.ActualResult = bug.ActualResult;
                bugInDb.ExpectedResult = bug.ExpectedResult;
            }

            _context.SaveChanges();

            return RedirectToAction("Details", "Projects", new {code = project.Code});
        }
    }
}