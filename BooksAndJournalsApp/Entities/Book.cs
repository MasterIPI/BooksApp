using System;
using System.Collections.Generic;

namespace Entities
{
    [Serializable]
    public class Book: PublishedEdition
    {
        public List<Author> Authors { get; set; }

        public Book(int id, string title)
        {
            Id = id;
            Title = title;
            Authors = new List<Author>();
        }
    }
}
