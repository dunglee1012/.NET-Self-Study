﻿using DemoCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCRUD.Logics
{
    internal class SubjectManager
    {
        public List<Subject> GetSubjects()
        {
            using (var context = new APContext())
            {
                return context.Subjects.ToList();
            }
        }
    }
}
