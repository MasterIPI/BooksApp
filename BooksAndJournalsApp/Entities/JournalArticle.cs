using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class JournalArticle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Author> Authors { get; set; }

        public JournalArticle(int id, string title)
        {
            Id = id;
            Name = title;
            Authors = new List<Author>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
