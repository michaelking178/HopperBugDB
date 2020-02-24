using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hopper.Models;

namespace Hopper.ViewModels
{
    public class BugFormViewModel
    {
        public Project Project { get; set; }
        public Bug Bug { get; set; }
    }
}