using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class JournalArticle
    {
        public string Article { get; set; }
        public List<Author> Authors { get; set; }

        public JournalArticle()
        {
            Authors = new List<Author>();
        }

        public JournalArticle(string title)
        {
            Article = title;
            Authors = new List<Author>();
        }

        public JournalArticle(string title, List<Author> authors)
        {
            Article = title;
            Authors = authors;
        }

        public override string ToString()
        {
            return Article;
        }
    }
}
