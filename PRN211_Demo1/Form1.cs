using Microsoft.EntityFrameworkCore;
using PRN211_Demo1.Logics;
using PRN211_Demo1.Models;

namespace PRN211_Demo1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BookManager bookManager = new BookManager();
            AuthorManager authorManager = new AuthorManager();

            cbBook.DisplayMember = "Title";
            cbBook.ValueMember = "Id";
            cbBook.DataSource = bookManager.GetBooks();

            cbYear.DisplayMember = "Year";
            cbYear.ValueMember = "Id";
            cbYear.DataSource = bookManager.GetBooks();

            lbAuthor.DisplayMember = "Name";
            lbAuthor.ValueMember = "Id";
            lbAuthor.DataSource = authorManager.GetAuthors();
        }

        private void lbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
            
        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book b = cbBook.SelectedItem as Book;
            if (b != null)
            {
                using (var context = new PRN211_Demo1Context())
                {
                    List<Book> books = context.Books
                        .Where(x => x.Title.Equals(b.Title) && x.Year == b.Year)
                        .ToList();
                    List<Author> authors = new List<Author>();
                    foreach (Book book in books)
                    {
                        authors = context.Authors
                            .Where(x => x.Books.Contains(book))
                            .ToList();
                    }
                    lbAuthor.DataSource = authors;

                }
            }
        }
    }
}