using Microsoft.EntityFrameworkCore;
using PRN211_Demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Demo1.Logics
{
    public class BookManager
    {
        public List<Book> GetBooks()
        {
            using (var context = new PRN211_Demo1Context())
            {
                return context.Books.ToList();
            }
        }
    }
}
