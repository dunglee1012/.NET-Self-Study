using System;
using System.Collections.Generic;

namespace New_Project_Form_PRN211.Models
{
    public partial class TuitionFeePerCourse
    {
        public string SubjectCode { get; set; } = null!;
        public string? SubjectName { get; set; }
        public int? NumberCredits { get; set; }
        public decimal? Fee { get; set; }
        public decimal? FeeInternational { get; set; }
        public string? TermId { get; set; }

        public virtual Term? Term { get; set; }
    }
}
