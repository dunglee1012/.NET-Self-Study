using New_Project_Form_PRN211.Logics;
using New_Project_Form_PRN211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Project_Form_PRN211
{
    public partial class AttendanceReport_Form : Form
    {
        public AttendanceReport_Form()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void AttendanceReport_Form_Load(object sender, EventArgs e)
        {   

            CampusManager manager = new CampusManager();
            cbCampus.DataSource = manager.GetCampuses();
            cbCampus.DisplayMember = "CampusName";
            cbCampus.ValueMember = "CampusID";
        }

        private void cbCampus_SelectedValueChanged(object sender, EventArgs e)
        {
            TermManager manager = new TermManager();
            cbTerm.DisplayMember = "TermId";
            cbTerm.ValueMember = "TermId";
            cbTerm.DataSource = manager.GetTerms();
        }

        private void cbTerm_SelectedValueChanged(object sender, EventArgs e)
        {
            ClassManager manager = new ClassManager();
            string id = (cbTerm.SelectedValue) as string;

            cbGroup.DataSource = manager.GetAllClasses(id);
            cbGroup.DisplayMember = "ClassName";
            cbGroup.ValueMember = "ClassId";

        }

        private void cbGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            CoursetimetableManger manager = new CoursetimetableManger();
            List<CourseTimetable> courseTimetables = manager.GetCoursetimetableMangers();

            dataGridView1.DataSource = courseTimetables
                .Select( x => new
                {
                    x.Date,
                    x.Slot,
                    x.Room,
                    x.Lecturer,
                    x.GroupName,
                    x.AttendanceStatus,
                    x.LectureComment,
                    x.Course
                }).ToList();
        }


    }
}
