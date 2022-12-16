using System;
using System.Collections.Generic;

namespace Project_Form_App_PRN211.Models
{
    public partial class Notification
    {
        public int NoId { get; set; }
        public string? NoTitle { get; set; }
        public DateTime? Date { get; set; }
        public string? Description { get; set; }
        public string? File { get; set; }
        public string? Note { get; set; }
    }
}
