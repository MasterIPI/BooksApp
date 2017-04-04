using Entities;
using Enums;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Views
{
    public interface IDeleteView
    {
        List<Book> Books { get; set; }
        List<Journal> Journals { get; set; }
        List<Newspaper> Newspapers { get; set; }
        ContentType Type { get; set; }
        DataGridViewRow CurrentRow { get; set; }
    }
}
