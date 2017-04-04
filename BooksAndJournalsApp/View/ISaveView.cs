using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views
{
    public interface ISaveView
    {
        List<Book> Books { get; set; } 
        List<Journal> Journals { get; set; }
        List<Newspaper> Newspapers { get; set; }

        string SaveBooksOption { get; set; }
        string SaveJournalsOption { get; set; }
        string SaveNewspapersOption { get; set; }
    }
}
