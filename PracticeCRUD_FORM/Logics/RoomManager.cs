using PracticeCRUD_FORM.Models;

namespace PracticeCRUD_FORM.Logics
{
    internal class RoomManager
    {
        public List<Room> GetRoom()
        {
            using (var context = new APContext())
            {
                return context.Rooms.ToList();
            }
        }

        public Lsit<Course> GetCourse()
        {
            using (var context = new APContext())
            {
                return context.Courses.ToList();
            }
        }
    }
}
