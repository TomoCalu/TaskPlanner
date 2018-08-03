using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskPlanner.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required, StringLength(160, MinimumLength = 2)]
        public string Name { get; set; }

        [Required, StringLength(160, MinimumLength = 2)]
        public string Surname { get; set; }

        public string Fullname
        {
            get
            {
                return string.Format("{0} {1}", Name, Surname);
            }
        }

        [Display(Name = "User tasks")]
        public virtual ICollection<Task> Tasks { get; set; }
    }
}