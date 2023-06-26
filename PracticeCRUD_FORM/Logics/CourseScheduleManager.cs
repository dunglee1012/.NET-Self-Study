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
                CourseSchedule cs = context.CourseSchedules
                    .FirstOrDefault(x =>
                    x.TeachingScheduleId == courseSchedule.TeachingScheduleId);
                if (cs != null)
                {
                    cs.TeachingScheduleId = courseSchedule.TeachingScheduleId;
                    cs.CourseId = courseSchedule.CourseId;
                    cs.TeachingDate = courseSchedule.TeachingDate;
                    cs.Slot = courseSchedule.Slot;
                    cs.RoomId = courseSchedule.RoomId;
                    cs.Description = courseSchedule.Description;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(int courseId)
        {

            using (var context = new APContext())
            {
                Course c = context.Courses
                    .Include(x => x.Students)
                    .FirstOrDefault(x => x.CourseId == courseId);
                if (c != null)
                {
                    List<CourseSchedule> courseSchedules = context.CourseSchedules
                        .Where(x => x.CourseId == courseId).ToList();
                    foreach (CourseSchedule cs in courseSchedules)
                    {
                        List<RollCallBook> rollCallBooks = context.RollCallBooks
                            .Where(x => x.TeachingScheduleId == cs.TeachingScheduleId).ToList();
                        context.RollCallBooks.RemoveRange(rollCallBooks);
                    }
                    context.CourseSchedules.RemoveRange(courseSchedules);

                    foreach(Student s in c.Students)
                    {
                        s.Courses.Remove(c);
                    }
                    context.Courses.Remove(c);
                    context.SaveChanges();
                }
            }
        }


    }
}
