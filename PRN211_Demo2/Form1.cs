using PRN211_Demo2.Manager;
using PRN211_Demo2.Models;
using System.Security.Cryptography.X509Certificates;

namespace PRN211_Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EmployeeManager manager = new EmployeeManager();


            Employee emp = new Employee();
            List<Employee> employees = manager.GetEmployees();
            emp.Id = 0;
            emp.Position = "All Position";
            employees.Add(emp);

            cbPosition.DisplayMember = "Position";
            cbPosition.ValueMember = "Id";
            cbPosition.DataSource = employees.DistinctBy(x => x.Position)
                .OrderBy(x => x.Position).ToList();
            LoadDataForDGV();
        }

        private void LoadDataForDGV()
        {
            EmployeeManager manager = new EmployeeManager();
            List<Employee> employees = manager.GetEmployees();
            dgvOutput.DataSource = employees.Select(x => new
            {
                x.Id,
                x.Name,
                x.Dob,
                x.Sex,
                x.Position,
                DepartmentId = x.DepartmentNavigation.Id,
                DepartmentName = x.DepartmentNavigation.Name
            }).ToList();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            string name = tbName.Text;

            EmployeeManager manager = new EmployeeManager();
            List<Employee> employees = manager.GetEmployeesByName(name);
            if (employees != null)
            {
                dgvOutput.DataSource = employees.Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Dob,
                    x.Sex,
                    x.Position,
                    DepartmentId = x.DepartmentNavigation.Id,
                    DepartmentName = x.DepartmentNavigation.Name
                }).ToList();
            }
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string position = cbPosition.Text;
            EmployeeManager manager = new EmployeeManager();
            if (position != "All Position")
            {
                List<Employee> employees = manager.GetEmployeesByPosition(position);
                if (employees != null)
                {
                    dgvOutput.DataSource = employees.Select(x => new
                    {
                        x.Id,
                        x.Name,
                        x.Dob,
                        x.Sex,
                        x.Position,
                        DepartmentId = x.DepartmentNavigation.Id,
                        DepartmentName = x.DepartmentNavigation.Name
                    }).ToList();
                }
            }
            else
            {
                LoadDataForDGV();
            }
        }

        private void rdMale_Female_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataForDGV();

        }

        private void rd_Male_CheckedChanged(object sender, EventArgs e)
        {
            string name = rd_Male.Text;
            EmployeeManager manager = new EmployeeManager();
            List<Employee> employees = manager.GetEmployeesBySex(name);
            if (employees != null)
            {
                dgvOutput.DataSource = employees.Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Dob,
                    x.Sex,
                    x.Position,
                    DepartmentId = x.DepartmentNavigation.Id,
                    DepartmentName = x.DepartmentNavigation.Name
                }).ToList();
            }
        }

        private void rd_Female_CheckedChanged(object sender, EventArgs e)
        {
            string name = rd_Female.Text;
            EmployeeManager manager = new EmployeeManager();
            List<Employee> employees = manager.GetEmployeesBySex(name);
            if (employees != null)
            {
                dgvOutput.DataSource = employees.Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Dob,
                    x.Sex,
                    x.Position,
                    DepartmentId = x.DepartmentNavigation.Id,
                    DepartmentName = x.DepartmentNavigation.Name
                }).ToList();
            }
        }
    }
}