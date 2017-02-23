using System;

namespace BooksAndJournalsApp
{
    [Serializable]
    public class Newspaper: PublishedEdition
    {
        public string Publisher { get; set; }

        public override string ToString()
        {
            return "Newspaper";
        }
    }
}
