using New_Project_Form_PRN211.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project_Form_PRN211.Logics
{
    internal class TuitionFeeManager
    {
        public List<TuitionFeePerCourse> GetTuitionFeePerCourses()
        {
            using (var context = new FapContext())
            {
                return context.TuitionFeePerCourses.ToList();
            }
        }
    }
}
