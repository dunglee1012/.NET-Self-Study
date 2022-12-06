using Microsoft.EntityFrameworkCore;
using PracticeListAndFilter.Models;

namespace PracticeListAndFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Department> departments = new List<Department>();
            List<Instructor> instructors = new List<Instructor>();
            List<Course> courses = new List<Course>();

            using (APContext context = new APContext())
            {
                var course = context.Courses
                    //Join
                    .Include(x => x.Instructor)
                    .Include(x => x.Instructor.Department)
                    //Where
                    .Select(x => new
                    {
                        x.CourseId,
                        x.CourseCode,
                        FullName = x.Instructor.InstructorFirstName + " "
                                    + x.Instructor.InstructorLastName,
                        DepartmentName = x.Instructor.Department.DepartmentName
                    })
                    .ToList();
                courses = context.Courses.ToList();
                departments = context.Departments.ToList();
            }
            //Add 1 "All Department" comboBox Department 
            Department d = new Department();
            d.DepartmentId = 0;
            d.DepartmentName = "All Department";
            departments.Insert(0, d);

            //Add 1 "All Courses" comboBox Course
            Course c = new Course();
            c.CourseId = 0;
            c.CourseCode = "All Course";
            courses.Insert(0, c);

            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.ValueMember = "DepartmentId";
            cbDepartment.DataSource = departments;

            cbCourse.DisplayMember = "CourseCode";
            cbCourse.ValueMember = "CourseId";
            cbCourse.DataSource = courses;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            int departmentId = Convert.ToInt32(cbDepartment.SelectedValue);
            int courseId = Convert.ToInt32(cbCourse.SelectedValue);

            using (APContext context = new APContext())
            {
                dvgOutput.DataSource = context.Courses
                    //JOIN
                    .Include(x => x.Instructor)
                    .Include(x => x.Instructor.Department)
                    //WHERE
                    .Where(x => ((x.Instructor.InstructorFirstName + " " + x.Instructor.InstructorLastName).Contains(name) || name.Equals("")))
                    .Where(x => (departmentId == 0 || x.Instructor.Department.DepartmentId == departmentId))
                    .Where(x => (courseId == 0 || x.CourseId == courseId))
                    //SELECT
                    .Select(x => new
                    {
                        x.Instructor.InstructorId,
                        Fullname = x.Instructor.InstructorFirstName + " " + x.Instructor.InstructorLastName,
                        x.Instructor.Department.DepartmentName,
                        x.CourseCode

                    })
                    .ToList();

            }
        }
    }
}