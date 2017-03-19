using System;
using System.Collections.Generic;

namespace Entities
{
    [Serializable]
    public class Newspaper: PublishedEdition
    {
        public string Publisher { get; set; }
        public List<string> Articles { get; set; }

        public Newspaper()
        {
            Articles = new List<string>();
        }

        public Newspaper(string title, string publisher)
        {
            Title = title;
            Publisher = publisher;
            Articles = new List<string>();
        }

        public Newspaper(string title, string publisher, List<string> articles)
        {
            Title = title;
            Publisher = publisher;
            Articles = articles;
        }
    }
}
