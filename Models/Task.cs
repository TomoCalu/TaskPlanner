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

        [StringLength(160, MinimumLength = 2)]
        public string Name { get; set; }

        [Required, StringLength(160, MinimumLength = 2)]
        public string Description { get; set; }
    }
}