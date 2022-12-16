using System;
using System.Collections.Generic;

namespace Project_Form_App_PRN211.Models
{
    public partial class Term
    {
        public Term()
        {
            Courses = new HashSet<Course>();
        }

        public int TermId { get; set; }
        public string? TermName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? Year { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
