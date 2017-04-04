using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views
{
    public interface IJournalAdd
    {
        string Title { get; set; }
        string Author { get; set; }
        int YearOfBirth { get; set; }
        string Article { get; set; }
    }
}
