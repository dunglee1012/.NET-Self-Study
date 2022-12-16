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
    public partial class Timetable_Form : Form
    {
        public Timetable_Form()
        {
            InitializeComponent();
        }

        private void ClassTimeTable_Form_Load(object sender, EventArgs e)
        {
            CampusManager manager = new CampusManager();
            lbCampus.DataSource = manager.GetCampuses();
            lbCampus.DisplayMember = "CampusName";
            lbCampus.ValueMember = "CampusID";
            flowLayoutPanel1.AutoScroll = true;
        }

        private void BackToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void lbCampus_SelectedValueChanged(object sender, EventArgs e)
        {
            TermManager manager = new TermManager();
            lbTerm.DisplayMember = "TermId";
            lbTerm.ValueMember = "TermId";
            lbTerm.DataSource = manager.GetTerms();
        }

        private void lbTerm_SelectedValueChanged(object sender, EventArgs e)
        {
            ClassManager manager = new ClassManager();
            string id = (lbTerm.SelectedValue) as string;
            //string id = "Spring2022";
            lbGroup.DataSource = manager.GetAllClasses(id);
            lbGroup.DisplayMember = "ClassName";
            lbGroup.ValueMember = "ClassId";
        }

        private void lbGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            string termId = "Spring2022";
           
            ClassManager manager = new ClassManager();
            CourseManager manager1= new CourseManager();
            List<Course> courses = manager1.GetCourses(termId);

            for (int i = 0; i < courses.Count; i++)
            {
                DataGridView dataGridView = new DataGridView();
                Label label = new Label();

                label.Text = courses[i].SubjectName;


                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dataGridView.EnableHeadersVisualStyles = false;
                dataGridView.Width = 800;
                dataGridView.Location = new System.Drawing.Point(0, i * (dataGridView.Height + 50));
                dataGridView.DataSource = manager.GetAllClassesTimetables(courses[i].SubjectCode);

                flowLayoutPanel1.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(dataGridView);

            }

        }
    }
}
