using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hopper.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(4, ErrorMessage = "The {0} value cannot exceed {1} characters")]
        public string Code { get; set; }
        public List<Bug> Bugs { get; set; }

        public Project()
        {
            Bugs = new List<Bug>();
        }
    }
}
