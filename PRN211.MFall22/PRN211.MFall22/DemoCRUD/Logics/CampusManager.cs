using DemoCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCRUD.Logics
{
    internal class CampusManager
    {
        public List<Campus> GetCampuses()
        {
            using (var context = new APContext())
            {
                return context.Campuses.ToList();
            }
        }
    }
}
