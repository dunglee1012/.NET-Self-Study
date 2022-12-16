using System;
using System.Collections.Generic;

namespace New_Project_Form_PRN211.Models
{
    public partial class CourseTimetable
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? Slot { get; set; }
        public string? Room { get; set; }
        public string? Lecturer { get; set; }
        public string? GroupName { get; set; }
        public string? AttendanceStatus { get; set; }
        public string? LectureComment { get; set; }
        public string? Course { get; set; }

        public virtual Course? CourseNavigation { get; set; }
    }
}
