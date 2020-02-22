using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hopper.Models
{
    public abstract class Issue
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

        public string IssueId { get; set; }
        public string ReportedBy { get; set; } // TODO: Change to type User model when it's ready
        public string Assignee { get; set; } // TODO: Change to type User model when it's ready
        public Status IssueStatus { get; set; }
        public Priority IssuePriority { get; set; }
        public string Summary { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public List<Comment> Comments { get; set; }
    }
}