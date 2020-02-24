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

        public Bug ()
        {
            Comments = new List<Comment>();
            IssueStatus = Status.New;
            CreatedOn = DateTime.Now;
        }
    }
}
