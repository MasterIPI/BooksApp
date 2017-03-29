using System;
using System.Collections.Generic;

namespace Entities
{
    [Serializable]
    public class Newspaper: PublishedEdition
    {
        public string Publisher { get; set; }
        public List<string> Articles { get; set; }

        public Newspaper(int id, string title, string publisher)
        {
            Id = id;
            Title = title;
            Publisher = publisher;
            Articles = new List<string>();
        }
    }
}
