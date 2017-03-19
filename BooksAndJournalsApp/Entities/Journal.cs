using System;
using System.Collections.Generic;

namespace Entities
{
    [Serializable]
    public class Journal: PublishedEdition
    {
        public List<JournalArticle> Articles { get; set; }

        public Journal()
        {
            Articles = new List<JournalArticle>();
        }

        public Journal(string title)
        {
            Title = title;
            Articles = new List<JournalArticle>();
        }

        public Journal (string title, List<JournalArticle> articles)
        {
            Title = title;
            Articles = articles;
        }
    }
}
