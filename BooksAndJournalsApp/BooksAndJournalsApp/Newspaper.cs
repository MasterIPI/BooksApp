using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndJournalsApp
{
    public class Newspaper: PublishedEdition
    {
        public string Publisher { get; set; }

        public override string ToString()
        {
            return "Newspaper";
        }
    }
}
