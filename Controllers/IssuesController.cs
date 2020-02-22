using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hopper.Models;
using Hopper.ViewModels;

namespace Hopper.Controllers
{
    public class IssuesController : Controller
    {
        private ApplicationDbContext _context;

        public IssuesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Projects");
        }

        public ActionResult Create(int id)
        {
            var project = _context.Projects.SingleOrDefault(p => p.Id == id);
            if (project == null)
                return HttpNotFound();

            var viewModel = new IssueFormViewModel();
            viewModel.Project = project;

            return View("IssuesForm", viewModel);
        }

        //[HttpPost]
        //public ActionResult Save()
        //{

        //}
    }
}