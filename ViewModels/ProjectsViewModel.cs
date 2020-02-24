using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hopper.Models;

namespace Hopper.ViewModels
{
    public class ProjectsViewModel
    {
        public IEnumerable<Project> Projects;
        public IEnumerable<Bug> Bugs;
    }
}