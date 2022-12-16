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
    public partial class TuitionFeePerCourse_Form : Form
    {
        public TuitionFeePerCourse_Form()
        {
            InitializeComponent();
        }

        private void TuitionFeePerCourse_Form_Load(object sender, EventArgs e)
        {
            LoadDataForDGV_TuitionFee();
        }

        private void LoadDataForDGV_TuitionFee()
        {
            TuitionFeeManager manager = new TuitionFeeManager();
            dgv_TuitionFee.DataSource = manager.GetTuitionFeePerCourses()
                .Select(x => new
                {
                    x.SubjectCode,
                    x.SubjectName,
                    x.NumberCredits,
                    x.Fee,
                    x.FeeInternational
                }).ToList();
        }

        private void BackToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
