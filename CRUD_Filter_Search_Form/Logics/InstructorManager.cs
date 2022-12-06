using CRUD_Filter_Search_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Filter_Search_Form.Logics
{
    internal class InstructorManager
    {
        public List<Instructor> GetInstructor()
        {
            using (var context = new APContext())
            {
                return context.Instructors.ToList();
            }
        }
    }
}
