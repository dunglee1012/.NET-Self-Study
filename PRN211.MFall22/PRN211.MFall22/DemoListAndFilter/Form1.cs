using DemoListAndFilter.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoListAndFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Subject> subjects = new List<Subject>();
            using (APContext context = new APContext())
            {
                var courses = context.Courses
                    //Join
                    .Include(x => x.Subject)
                    .Include(x => x.Instructor.Courses)

                    //select id,code,des,subjectid,intrucId from Course
                    .Select(x => new
                    {
                        x.CourseId,
                        x.CourseCode,
                        x.CourseDescription,
                        SubjectName = x.Subject.SubjectName,
                        InstructorName = x.Instructor.InstructorFirstName
                        + " " + x.Instructor.InstructorLastName
                    })
                    .ToList();
                subjects = context.Subjects.ToList();
            }
            Subject s = new Subject();
            s.SubjectId = 0;
            s.SubjectName = "ALL SUBJECTS";
            subjects.Insert(0, s);

            cbSubjects.DisplayMember = "SubjectName";
            cbSubjects.ValueMember = "SubjectId";
            cbSubjects.DataSource = subjects;

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string code = tbCode.Text.Trim();
            int subjectId = Convert.ToInt32(cbSubjects.SelectedValue);
            using (APContext context = new APContext())
            {
                dvgCourses.DataSource = context.Courses
                    //where
                    .Where(x => x.CourseCode.Contains(code))
                    .Where(x => (subjectId == 0) || x.SubjectId == subjectId)

                    //Join
                    .Include(x => x.Subject)
                    .Include(x => x.Instructor)

                    //select id,code,des,subjectid,intrucId from Course
                    .Select(x => new
                    {
                        x.CourseId,
                        x.CourseCode,
                        x.CourseDescription,
                        SubjectNamee = x.Subject.SubjectName,
                        InstructorName = x.Instructor.InstructorFirstName + " " + x.Instructor.InstructorLastName
                    })
                    .ToList();
            }
        }
    }
}