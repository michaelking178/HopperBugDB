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
        [Display(Name = "Project Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(4, ErrorMessage = "The {0} value cannot exceed {1} characters")]
        [Display(Name = "Project Code")]
        public string Code { get; set; }

        public DateTime Created { get; set; }

        public List<Bug> Bugs { get; set; }

        public Project()
        {
            Created = DateTime.Now;
            Bugs = new List<Bug>();
        }
    }
}
