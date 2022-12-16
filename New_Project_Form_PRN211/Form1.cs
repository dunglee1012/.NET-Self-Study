using New_Project_Form_PRN211.Logics;
using New_Project_Form_PRN211.Models;

namespace New_Project_Form_PRN211
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_ClassTimetable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timetable_Form form = new Timetable_Form();
            form.ShowDialog();
        }

        private void linkLabel_TuitionPerCourse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TuitionFeePerCourse_Form form = new TuitionFeePerCourse_Form();
            form.ShowDialog();
        }

        private void linkLabel_ExamSchedule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExamSchedule_Form form = new ExamSchedule_Form();
            form.ShowDialog();
        }

        private void linkLabel_AttendReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AttendanceReport_Form form = new AttendanceReport_Form();
            form.ShowDialog();
        }
    }
}