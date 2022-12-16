using CRUD_Filter_Search_Form.Logics;
using CRUD_Filter_Search_Form.Models;
using System.Net.Http.Headers;

namespace CRUD_Filter_Search_Form
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
            InstructorManager instructorManager = new InstructorManager();
            CampusManager campusManager = new CampusManager();

            cbSubjects.DisplayMember = "SubjectCode";
            cbSubjects.ValueMember = "SubjectId";
            cbSubjects.DataSource = subjectManager.GetSubjects();

            cbInstructor.DisplayMember = "InstructorName";
            cbInstructor.ValueMember = "InstructorId";
            cbInstructor.DataSource = instructorManager.GetInstructor();

            cbTerms.DisplayMember = "TermName";
            cbTerms.ValueMember = "TermId";
            cbTerms.DataSource = termManager.GetTerms();

            cbCampus.DisplayMember = "CampusName";
            cbCampus.ValueMember = "CampusId";
            cbCampus.DataSource = campusManager.GetCampus();

            LoadDataForDGV();
        }

        private void LoadDataForDGV()
        {
            CourseManager courseManager = new CourseManager();
            courses = courseManager.GetCourses();
            dgvOutput.DataSource = courses
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

        private void dgvOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string data = dgvOutput.Rows[e.RowIndex].Cells[0].Value;
            if (e.RowIndex == 0 || e.ColumnIndex < 0) { return; }
            Course currentCourse = courses[e.RowIndex];

            tbCourseID.Text = currentCourse.CourseId.ToString();
            tbCourseCode.Text = currentCourse.CourseCode;
            tbCourseDescription.Text = currentCourse.CourseDescription;

            cbSubjects.SelectedValue = currentCourse.SubjectId;
            cbCampus.SelectedValue = currentCourse.CampusId;
            cbInstructor.SelectedValue = currentCourse.InstructorId;
            cbTerms.SelectedValue = currentCourse.TermId;
        }

        private Course GetCourseInfo()
        {
            Course course = new Course();
            if (tbCourseID.Text != string.Empty)
                course.CourseId = Convert.ToInt32(tbCourseID.Text);
            course.CourseCode = tbCourseCode.Text;
            course.CourseDescription = tbCourseDescription.Text;
            course.SubjectId = cbSubjects..SelectedValue;
            course.Instructor = cbInstructor.SelectedValue;
            course.CampusId = cbCampus.SelectedValue;

            return course;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CourseManager cm = new CourseManager();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}