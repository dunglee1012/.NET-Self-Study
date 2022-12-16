using Project_Form_App_PRN211.Manager;
using Project_Form_App_PRN211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Form_App_PRN211
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();

        }

        public void HomeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadDataForDGVNotification()
        {
            NotificationManager manager = new NotificationManager();
            List<Notification> list = manager.GetNotifications();
            dgvNotification.DataSource = list.Select(x => new
            {
                x.Date,
                x.Description,
                x.File,
                x.Note
            }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure to Sign Out", "Sign Out", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void linklabelViewSemester_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TermForm sf = new TermForm();
            sf.ShowDialog();
            this.Hide();
        }

        private void HomeForm_Load_1(object sender, EventArgs e)
        {
            LoadDataForDGVNotification();
        }

        private void dgvNotification_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
