using System;
using System.Collections.Generic;

namespace Entities
{
    [Serializable]
    public class Journal: PublishedEdition
    {
        public List<JournalArticle> Articles { get; set; }

        public Journal(int id, string title)
        {
            Id = id;
            Title = title;
            Articles = new List<JournalArticle>();
        }
    }
}
