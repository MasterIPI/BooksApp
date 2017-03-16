using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class JournalArticle
    {
        public string Title { get; set; }
        public Author Author { get; set; }

        public JournalArticle(string title, Author author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return Title + ", " + Author.Name + ", " + Author.YearOfBirth.ToString();
        }
    }
}
