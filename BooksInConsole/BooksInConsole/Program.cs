using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksInConsole
{
    class Program
    {
        static void Main()
        {
            List<Book> library = new List<Book>();
            Book book = new Book();

            for (int i = 0; i < 10; i++)
            {
                book.Title = "Title" + (i + 1).ToString();
                book.Author = "Author" + (i + 1).ToString();
                library.Add(book);
            }

            ViewHelper.ShowBookList(library);
        }
    }
}
