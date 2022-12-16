using System;
using System.Collections.Generic;

namespace New_Project_Form_PRN211.Models
{
    public partial class Class
    {
        public Class()
        {
            Courses = new HashSet<Course>();
        }

        public int ClassId { get; set; }
        public string? ClassName { get; set; }
        public string? TermId { get; set; }

        public virtual Term? Term { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
