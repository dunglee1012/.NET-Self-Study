using System;
using System.Collections.Generic;

namespace New_Project_Form_PRN211.Models
{
    public partial class ExamSchedule
    {
        public int Id { get; set; }
        public string? SubjectCode { get; set; }
        public string? SubjectName { get; set; }
        public DateTime? Date { get; set; }
        public string? RoomNo { get; set; }
        public string? Time { get; set; }
        public string? ExamForm { get; set; }
        public string? Exam { get; set; }
        public DateTime? DateOfPublication { get; set; }

        public virtual Course? SubjectCodeNavigation { get; set; }
    }
}
