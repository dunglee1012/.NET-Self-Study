using Project_Form_App_PRN211.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Form_App_PRN211.Manager
{
    internal class TermManager
    {
        public List<Term> GetTerms()
        {
            using (var context = new APContext())
            {
                var list = context.Terms
                     .ToList();
                return list;

            }
        }
    }
}
