using Models;
using Views;
using System.Collections.Generic;
using System.Linq;
using Enums;
using System;

namespace Presenters
{
    public class MainPresenter
    {
        private BookModel _bookModel;
        private JournalModel _journalModel;
        private NewspaperModel _newspaperModel;
        private IMainView _view;

        public MainPresenter(IMainView view)
        {
            _bookModel = new BookModel();
            _journalModel = new JournalModel();
            _newspaperModel = new NewspaperModel();
            _view = view;
        }

        public List<string> GetListDataSources()
        {
            return Enum.GetNames(typeof(ContentType)).ToList();
        }

        public void UpdateData()
        {
            _view.Books.Clear();
            _view.Journals.Clear();
            _view.Newspapers.Clear();
            _view.Books = _bookModel.UpdateBooks();
            _view.Journals.AddRange(_journalModel.UpdateJournals());
            _view.Newspapers.AddRange(_newspaperModel.UpdateNewspapers());
        }
    }
}
