﻿using System;
using System.Collections.Generic;

namespace Project_Form_App_PRN211.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Courses = new HashSet<Course>();
        }

        public int SubjectId { get; set; }
        public string? SubjectCode { get; set; }
        public string? SubjectName { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
