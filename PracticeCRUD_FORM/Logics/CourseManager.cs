using PracticeCRUD_FORM.Models;

namespace PracticeCRUD_FORM.Logics
{
    internal class CourseManager
    {
        public List<Course> GetCourses()
        {
            using (var context = new APContext())
            {
                return context.Courses.ToList();
            }
        }
    }
}
