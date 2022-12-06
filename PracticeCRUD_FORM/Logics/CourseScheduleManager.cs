using Microsoft.EntityFrameworkCore;
using PracticeCRUD_FORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCRUD_FORM.Logics
{
    internal class CourseScheduleManager
    {
        public List<CourseSchedule> GetCourseSchedules()
        {
            using (var context = new APContext())
            {
                return context.CourseSchedules
                    .Include(x => x.Room)
                    .Include(x => x.Course)
                    .ToList();
            }
        }

        public void AddCourseScedule(CourseSchedule cs)
        {
            using (var context = new APContext())
            {
                context.CourseSchedules.Add(cs);
                context.SaveChanges();
            }
        }

        public void Edit(CourseSchedule courseSchedule)
        {
            using (var context = new APContext())
            {
                CourseSchedule cs = context.CourseSchedules.FirstOrDefault(x => x.TeachingScheduleId == courseSchedule.TeachingScheduleId);
                if(cs != null)
                {
                    cs.TeachingScheduleId = courseSchedule.TeachingScheduleId;
                    cs.CourseId = courseSchedule.CourseId;
                    cs.TeachingDate = courseSchedule.TeachingDate;
                    cs.Slot = courseSchedule.Slot;
                    cs.RoomId = courseSchedule.RoomId;
                    cs.Description= courseSchedule.Description;
                    context.SaveChanges();
                }

            }
        }

        public void Delete(int courseScheduleId)
        {
              using(var context = new APContext())
            {
                CourseSchedule cs = context.CourseSchedules
                    .Include
            }
        }
    }
}
