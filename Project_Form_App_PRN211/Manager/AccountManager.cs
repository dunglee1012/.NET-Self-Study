using Project_Form_App_PRN211.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Form_App_PRN211.Manager
{
    public class AccountManager
    {
        APContext context = new APContext();

        public Account GetAccount(string username, string password)
        {
            using (var context = new APContext())
            {
                return context.Accounts.FirstOrDefault(x => x.UserName == username && x.Password == password);
            }

        }

        public void AddAccount(Account account)
        {
            using (var context = new APContext())
            {
                //context.Accounts.Add(account);
                context.SaveChanges();
            }
        }
    }
}

