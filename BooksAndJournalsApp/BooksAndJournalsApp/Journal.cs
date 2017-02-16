﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndJournalsApp
{
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
