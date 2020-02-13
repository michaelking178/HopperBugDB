using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hopper.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Bug> Bugs { get; set; }

        public Project()
        {
            Bugs = new List<Bug>();
        }
    }
}
