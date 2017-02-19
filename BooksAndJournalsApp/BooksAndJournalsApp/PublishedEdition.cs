using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndJournalsApp
{
    [Serializable]
    public abstract class PublishedEdition
    {
        public string Title { get; set; }
    }
}
