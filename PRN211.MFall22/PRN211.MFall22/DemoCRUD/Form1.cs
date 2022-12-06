using DemoCRUD.Logics;
using DemoCRUD.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DemoCRUD
{
    public partial class Form1 : Form
    {
        List<Course> courses;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            SubjectManager subjectManager = new SubjectManager();
            TermManager termManager = new TermManager();
            InstrutorManager instrutorManager = new InstrutorManager();
            CampusManager campusManager = new CampusManager();                

            cbSubjects.DisplayMember = "SubjectName";
            cbSubjects.ValueMember = "SubjectId";
            cbSubjects.DataSource = subjectManager.GetSubjects();

            cbTerms.DisplayMember = "TermName";
            cbTerms.ValueMember = "TermId";
            cbTerms.DataSource = termManager.GetTerms();

            cbCampus.DisplayMember = "CampusName";
            cbCampus.ValueMember = "CampusId";
            cbCampus.DataSource = campusManager.GetCampuses();

            cbInstructors.DisplayMember = "InstructorFirstName";
            cbInstructors.ValueMember = "InstructorId";
            cbInstructors.DataSource = instrutorManager.GetInstructors();

            LoadDataForDGV();
        }

        private void LoadDataForDGV()
        {
            CourseManager courseManager = new CourseManager();
            courses = courseManager.GetCourses();
            dataGridView1.DataSource = courses
                .Select(x => new
                {
                    x.CourseId,
                    x.CourseCode,
                    x.CourseDescription,
                    InstructorName = x.Instructor.InstructorFirstName + " " + x.Instructor.InstructorLastName,
                    Subject = x.Subject.SubjectName,
                    Term = x.Term.TermName,
                    Campus = x.Campus.CampusName
                }).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            Course currentCourse = courses[e.RowIndex];
            tbId.Text = currentCourse.CourseId.ToString();
            tbCode.Text = currentCourse.CourseCode;
            tbDescription.Text = currentCourse.CourseDescription;
            cbSubjects.SelectedValue = currentCourse.SubjectId;
            cbInstructors.SelectedValue = currentCourse.InstructorId;
            cbTerms.SelectedValue = currentCourse.TermId;
            cbCampus.SelectedValue = currentCourse.CampusId;
        }

        //lay du lieu 1 Course tu GroupBox
        private Course GetCourseInfo()
        {
            Course course = new Course();            
            course.CourseCode = tbCode.Text;
            course.CourseDescription = tbDescription.Text;
            course.SubjectId = Convert.ToInt32(cbSubjects.SelectedValue);
            course.InstructorId = Convert.ToInt32(cbInstructors.SelectedValue);
            course.TermId = Convert.ToInt32(cbTerms.SelectedValue);
            course.CampusId = Convert.ToInt32(cbCampus.SelectedValue);
            return course;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            CourseManager courseManager = new CourseManager();
            courseManager.AddCourse(GetCourseInfo());
            LoadDataForDGV();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            tbId.Text = String.Empty;
            tbCode.Text = String.Empty;
            tbDescription.Text = String.Empty;
            cbSubjects.SelectedIndex = 0;
            cbInstructors.SelectedIndex = 0;
            cbTerms.SelectedIndex = 0;
            cbCampus.SelectedIndex = 0;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Course course = GetCourseInfo();
            if (tbId.Text != String.Empty)
                course.CourseId = Convert.ToInt32(tbId.Text);
            CourseManager courseManager = new CourseManager();
            courseManager.Edit(course);
            LoadDataForDGV();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
                int courseId = 0;
                if (tbId.Text != String.Empty)
                    courseId = Convert.ToInt32(tbId.Text);
                CourseManager courseManager = new CourseManager();
                courseManager.Delete(courseId);
                LoadDataForDGV();
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show("Khong xoa dc dau.");
            //}
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}