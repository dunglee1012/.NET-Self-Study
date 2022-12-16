using New_Project_Form_PRN211.Logics;
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
    public partial class ExamSchedule_Form : Form
    {
        public ExamSchedule_Form()
        {
            InitializeComponent();
        }

        private void ExamSchedule_Form_Load(object sender, EventArgs e)
        {
            LoadDataForDGV_ExamSchedule();
        }

        private void LoadDataForDGV_ExamSchedule()
        {
            ExamScheduleManager manager = new ExamScheduleManager();
            dgv_ExamSchedule.DataSource = manager.GetExamSchedules()
                .Select(x => new
                {
                    x.SubjectCode,
                    x.SubjectName,
                    x.Date,
                    x.RoomNo,
                    x.Time,
                    x.ExamForm,
                    x.Exam,
                    x.DateOfPublication
                }).ToList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
