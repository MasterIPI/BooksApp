using System;

namespace Entities
{
    [Serializable]
    public class Journal: PublishedEdition
    {
        public JournalArticle Article { get; set; }

        public Journal (string title, Author author, string article)
        {
            Title = title;
            Article = new JournalArticle(article, author);
        }
    }
}
