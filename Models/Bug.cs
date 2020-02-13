using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hopper.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public Project Project { get; set; }
        public string BugId { get; set; }
        public string ReportedBy { get; set; } // TODO: Change to type User model when it's ready
        public string Assignee { get; set; } // TODO: Change to type User model when it's ready
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Summary { get; set; }
        public string StepsToReproduce { get; set; }
        public string ActualResult { get; set; }
        public string ExpectedResult { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public Bug(Project project, int id)
        {
            Id = id;
            BugId = project.Code + "-" + Id.ToString("D4");
        }
    }
}
