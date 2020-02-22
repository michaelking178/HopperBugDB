using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hopper.Models
{
    public class Bug : Issue
    {
        public string StepsToReproduce { get; set; }
        public string ActualResult { get; set; }
        public string ExpectedResult { get; set; }

        public Bug(Project project, int id) // Manual ID assignment will be removed when integrated with SQL.
        {
            Id = id;
            IssueId = project.Code + "-" + Id.ToString("D4");
            Comments = new List<Comment>();
            IssueStatus = Status.New;
            CreatedOn = DateTime.Now;
        }
    }
}
