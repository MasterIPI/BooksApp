using Entities;
using System.Collections.Generic;

namespace Views
{
    public interface IMainView
    {
        List<Book> Books { get; set; }
        List<Journal> Journals { get; set; }
        List<Newspaper> Newspapers { get; set; }

        void UpdateViewedData();
        void CallDeleteView();
        void CallAddBookView();
        void CallAddJournalView();
        void CallAddNewspaperView();
        void CallSaveView();
    }
}
