using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hopper.Models;

namespace Hopper.ViewModels
{
    public class IssueFormViewModel
    {
        public Project Project { get; set; }
        public Issue Issue { get; set; }
    }
}