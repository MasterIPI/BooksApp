using System;

namespace Entities
{
    [Serializable]
    public class Newspaper: PublishedEdition
    {
        public string Publisher { get; set; }
        public string Article { get; set; }

        public Newspaper(string title, string publisher, string article)
        { 
            Title = title;
            Publisher = publisher;
            Article = article;
        }
    }
}
