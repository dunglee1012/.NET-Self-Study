using System;
using System.Collections.Generic;

namespace New_Project_Form_PRN211.Models
{
    public partial class Campus
    {
        public Campus()
        {
            Terms = new HashSet<Term>();
        }

        public int CampusId { get; set; }
        public string? CampusName { get; set; }

        public virtual ICollection<Term> Terms { get; set; }
    }
}