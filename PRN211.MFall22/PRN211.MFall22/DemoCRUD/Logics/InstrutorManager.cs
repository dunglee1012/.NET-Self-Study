using DemoCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCRUD.Logics
{
    internal class InstrutorManager
    {
        public List<Instructor> GetInstructors()
        {
            using (var context = new APContext())
            {
                return context.Instructors.ToList();
            }
        }
    }
}
