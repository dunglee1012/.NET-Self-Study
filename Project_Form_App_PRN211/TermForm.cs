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
    public partial class TermForm : Form
    {
        public TermForm()
        {
            InitializeComponent();
        }

        private void TermForm_Load(object sender, EventArgs e)
        {
            TermManager manager = new TermManager();
            cbYear.DisplayMember = "Year";
            cbYear.ValueMember = "TermId";
            cbYear.DataSource = manager.GetTerms();

            LoadDataForDGVTerm();
        }

        private void LoadDataForDGVTerm()
        {
            TermManager manager = new TermManager();
            List<Term> terms = manager.GetTerms();
            dgvTerm.DataSource = terms.Select(x => new
            {
                x.TermName,
                x.FromDate,
                x.ToDate
            }).ToList();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(cbYear.SelectedValue);
            using (APContext context = new APContext())
            {
                dgvTerm.DataSource = context.Terms
                    .Where(x => x.Year == year)

                    .Select(x => new
                    {
                        x.TermName,
                        x.FromDate,
                        x.ToDate
                    }).ToList();
            }
        }
    }
}
