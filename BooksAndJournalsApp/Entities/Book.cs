using System;
using System.Collections.Generic;

namespace Entities
{
    [Serializable]
    public class Book: PublishedEdition
    {
        public List<Author> Authors { get; set; }

        public Book ()
        {
            Authors = new List<Author>();
        }

        public Book(string title)
        {
            Title = title;
            Authors = new List<Author>();
        }

        public Book (string title, List<Author> authors)
        {
            Title = title;
            Authors = authors;
        }
    }
}
