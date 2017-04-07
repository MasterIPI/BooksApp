using Entities;
using Enums;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Views
{
    public interface IDeleteBookView
    {
        List<Book> Books { get; set; }
        DataGridViewRow CurrentRow { get; set; }
    }
}
