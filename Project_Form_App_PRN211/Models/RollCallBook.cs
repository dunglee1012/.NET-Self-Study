using System;
using System.Collections.Generic;

namespace Project_Form_App_PRN211.Models
{
    public partial class RollCallBook
    {
        public int RollCallBookId { get; set; }
        public int? TeachingScheduleId { get; set; }
        public int? StudentId { get; set; }
        public bool? IsAbsent { get; set; }
        public string? Comment { get; set; }

        public virtual Student? Student { get; set; }
        public virtual CourseSchedule? TeachingSchedule { get; set; }
    }
}
