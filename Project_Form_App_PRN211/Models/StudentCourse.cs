using System;
using System.Collections.Generic;

namespace Project_Form_App_PRN211.Models
{
    public partial class StudentCourse
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public int? Mark { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
