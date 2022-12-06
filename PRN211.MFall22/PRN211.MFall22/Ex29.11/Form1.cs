
using Ex29._11.Logics;
using Ex29._11.Models;
using System.Data;
using System.Windows.Forms;

namespace Ex29._11
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        Student GetStudentInfo()
        {


            Student s = new Student();
            s.Id = Convert.ToInt32(tbID.Text);
            s.Name = tbName.Text;
            s.Dob = dtpDob.Value;
            s.Major = cbMajors.SelectedItem.ToString();
            s.Gpa = (float)nudGPA.Value;
            return s;
        }

        public Boolean checkIdExist(int id, List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.Id == id)
                {
                    return true;
                }
            }
            return false;

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {

                Student s = GetStudentInfo();
                if (checkIdExist(s.Id, students))
                {
                    MessageBox.Show("ID da ton tai");
                }
                else
                {
                    students.Add(s);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = students;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Du lieu nao do ko dung format, hay kiem tra lai.");
            }

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = @"D:\";
            fileDialog.Filter = "Text file | *.txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = fileDialog.FileName;
                StudentList.WriteToFile(students, filename);
                MessageBox.Show("Ghi file thanh cong.");
            }

        }

        private void DeleteStudent()
        {
            Student student = students.Where(s => s.Id == Convert.ToInt32(tbID.Text)).FirstOrDefault();
            if (student != null)
            {
                students.Remove(student);
            }
            else
            {
                MessageBox.Show("id ko ton tai ");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteStudent();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = students;
                dataGridView1.Refresh();
            }
            catch (FormatException)
            {
                MessageBox.Show("Can not delete");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Student> listSearch = new List<Student>();

            //Search by Name
            //listSearch = students.Where(s => s.Major == cbMajors.SelectedItem.ToString()).ToList();

            //Search By GPA
            listSearch = students.Where(s => s.Gpa >= (float)nudGPA.Value).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listSearch;
            dataGridView1.Refresh();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Student student = students.Where(s => s.Id == Convert.ToInt32(tbID.Text)).FirstOrDefault();
            if (student == null)
            {
                MessageBox.Show("ID khong ton tai");
            }
            else
            {
                Student studentUpdate = new Student();
                studentUpdate.Id = student.Id;
                studentUpdate.Name = tbName.Text;
                studentUpdate.Dob = dtpDob.Value;
                studentUpdate.Major = cbMajors.SelectedItem.ToString();
                studentUpdate.Gpa = (float)nudGPA.Value;

                students.Remove(student);
                students.Add(studentUpdate);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = students;
                dataGridView1.Refresh();
            }

        }
    }
}