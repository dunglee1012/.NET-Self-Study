using System;
using System.Collections.Generic;

namespace New_Project_Form_PRN211.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseTimetables = new HashSet<CourseTimetable>();
            ExamSchedules = new HashSet<ExamSchedule>();
        }

        public string SubjectCode { get; set; } = null!;
        public string? SubjectName { get; set; }
        public string? GroupName { get; set; }
        public DateTime? StartDate { get; set; }
        public string? TermId { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual Term? Term { get; set; }
        public virtual ICollection<CourseTimetable> CourseTimetables { get; set; }
        public virtual ICollection<ExamSchedule> ExamSchedules { get; set; }
    }
}
