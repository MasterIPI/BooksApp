using System;

namespace Entities
{
    [Serializable]
    public class Journal: PublishedEdition
    {
        public string Author { get; set; }
        public string Articles { get; set; }

        public override string ToString()
        {
            return "Journal";
        }
    }
}
