using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskPlanner.Models
{
    public class Task
    {
        public int ID { get; set; }

        [Required, StringLength(110, MinimumLength = 2)]
        public string Description { get; set; }

        public bool IsDone { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}