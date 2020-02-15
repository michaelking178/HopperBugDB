using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hopper.Models
{
    public class Bug
    {
        public enum Status
        {
            New,
            Open,
            NeedMoreInformation,
            Resolved,
            WontDo,
            Closed
        }

        public enum Priority
        {
            Blocker,
            High,
            Medium,
            Low
        }

        public int Id { get; set; }
        [Required]
        public Project Project { get; set; }
        public string BugId { get; set; }
        public string ReportedBy { get; set; } // TODO: Change to type User model when it's ready
        public string Assignee { get; set; } // TODO: Change to type User model when it's ready
        public Status BugStatus { get; set; }
        public Priority BugPriority { get; set; }
        public string Summary { get; set; }
        public string StepsToReproduce { get; set; }
        public string ActualResult { get; set; }
        public string ExpectedResult { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public List<Comment> Comments { get; set; }

        public Bug(Project project, int id)
        {
            Id = id;
            BugId = project.Code + "-" + Id.ToString("D4");
            Comments = new List<Comment>();
            BugStatus = Status.New;
        }
    }
}
