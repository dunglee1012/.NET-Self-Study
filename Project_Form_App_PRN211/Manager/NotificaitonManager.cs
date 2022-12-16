using Project_Form_App_PRN211.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Form_App_PRN211.Manager
{
    internal class NotificationManager
    {
        internal List<Notification> GetNotifications()
        {
            using (var context = new APContext())
            {
                return context.Notifications
                    .OrderByDescending(x => x.Date)
                    .ToList();
            }
        }
    }
}
