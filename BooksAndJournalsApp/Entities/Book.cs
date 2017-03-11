using System;

namespace Entities
{
    [Serializable]
    public class Book: PublishedEdition
    {
        public string Author { get; set; }

        public override string ToString()
        {
            return "Book";
        }
    }
}
