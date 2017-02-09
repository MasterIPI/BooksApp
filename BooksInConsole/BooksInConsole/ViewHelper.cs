using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksInConsole
{
    public static class ViewHelper
    {
        public static void ShowBookList(List<Book> list)
        {
            foreach (Book book in list)
            {
                Console.WriteLine(string.Format($"Book:\n{book.Title}, Author - {book.Author}\n"));
            }
            Console.ReadKey();
        }
    }
}
