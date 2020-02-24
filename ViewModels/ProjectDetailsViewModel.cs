using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hopper.Models;

namespace Hopper.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public Project Project;
        public IEnumerable<Bug> Bugs;
    }
}