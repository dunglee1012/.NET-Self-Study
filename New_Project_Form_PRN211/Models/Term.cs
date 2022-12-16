using System;
using System.Collections.Generic;

namespace New_Project_Form_PRN211.Models
{
    public partial class Term
    {
        public Term()
        {
            Classes = new HashSet<Class>();
            Courses = new HashSet<Course>();
            TuitionFeePerCourses = new HashSet<TuitionFeePerCourse>();
        }


        public string TermId { get; set; }
        public int CampusId { get; set; }
        public Term(string termID, int campusID)
        {
            TermId = termID;
            CampusId = campusID;
        }

        public virtual Campus Campus { get; set; } = null!;
        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<TuitionFeePerCourse> TuitionFeePerCourses { get; set; }
    }
}
