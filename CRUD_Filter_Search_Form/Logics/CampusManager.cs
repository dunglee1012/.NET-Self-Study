using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_Filter_Search_Form.Models;

namespace CRUD_Filter_Search_Form.Logics
{

    internal class CampusManager
    {
        public List<Campus> GetCampus()
        {
            using (var context = new APContext())
            {
                return context.Campuses.ToList();
            }
        }
    }

}
