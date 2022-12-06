using CRUD_Filter_Search_Form.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Filter_Search_Form.Logics
{
    internal class CourseManager
    {
        public List<Course> GetCourses()
        {
            using (var context = new APContext())
            {
                return context.Courses
                    .Include(x => x.Subject)
                    .Include(x => x.Campus)
                    .Include(x => x.Instructor)
                    .Include(x => x.Term)
                    .ToList();
            }
        }

        public void AddCourse(Course course)
        {
            using (var context = new APContext())
            {
                context.Courses.Add(course);
                context.SaveChanges();
            }
        }

        public void RemoveCourse(int courseId)
        {
            using (var context = new APContext())
            {
                Course c = context.Courses.FirstOrDefault(x => x.CourseId == courseId);
                if (c != null)
                {
                    context.Courses.Remove(c);
                    context.SaveChanges();
                }
            }
        }

        public void EditCourse(Course course)
        {
            using (var context = new APContext())
            {
                Course c = context.Courses.FirstOrDefault(x => x.CourseId == course.CourseId);
                if (c != null)
                {
                    c.CourseCode = course.CourseCode;
                    c.CourseDescription = course.CourseDescription;
                    c.SubjectId = course.SubjectId;
                    c.InstructorId = course.InstructorId;
                    c.TermId = course.TermId;
                    c.CampusId = course.CampusId;
                    context.SaveChanges();
                }
            }
        }
    }

}

