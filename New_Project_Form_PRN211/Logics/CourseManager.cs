using New_Project_Form_PRN211.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project_Form_PRN211.Logics
{
    internal class CourseManager
    {
        public List<Course> GetCourses(string id)
        {
            using(var list = new FapContext())
            {
                return list.Courses.ToList();
            }
        }
    }
}
