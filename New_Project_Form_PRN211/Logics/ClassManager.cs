using Microsoft.EntityFrameworkCore;
using New_Project_Form_PRN211.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project_Form_PRN211.Logics
{
    internal class ClassManager
    {
        public List<Class> GetAllClasses(string id)
        {
            using (var list = new FapContext())
            {
                return list.Classes
                    .Include(x => x.Term)
                    .Where(x => x.TermId == id)
                    .ToList();
            }
        }

        public List<CourseTimetable> GetAllClassesTimetables(string courseId) {
            using (var list = new FapContext())
            {
                return list.CourseTimetables.Where(x=> x.Course == courseId)
                    .ToList();
            }
        }
    }
}
