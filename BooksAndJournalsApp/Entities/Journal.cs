using System;

namespace Entities
{
    [Serializable]
    public class Journal: PublishedEdition
    {
        public Author Author { get; set; }
        public string Article { get; set; }

        public Journal (string title, Author author, string article)
        {
            Title = title;
            Author = author;
            Article = article;
        }
    }
}
