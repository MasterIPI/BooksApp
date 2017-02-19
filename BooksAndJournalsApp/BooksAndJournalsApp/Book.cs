using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndJournalsApp
{
    [Serializable]
    public class Book: PublishedEdition
    {
        public string Author { get; set; }

        public override string ToString()
        {
            return "Book";
        }
    }
}
