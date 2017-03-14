using System;

namespace Entities
{
    [Serializable]
    public class Book: PublishedEdition
    {
        public Author Author { get; set; }

        public Book (string title, Author author)
        {
            Title = title;
            Author = author;
        }
    }
}
