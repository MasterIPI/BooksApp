using Models;
using Views;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Entities;
using AdditionalDataProvider;
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

        public dynamic GetContentFromName(string contentType)
        {
            if (contentType == ContentType.Book.ToString())
            {
                return _bookModel.Books;
            }

            if (contentType == ContentType.Journal.ToString())
            {
                return _journalModel.Journals;
            }

            if (contentType == ContentType.Newspaper.ToString())
            {
                return _newspaperModel.Newspapers;
            }

            return null;
        }

        public void UpdateData()
        {
            _bookModel.UpdateBooks();
            _journalModel.UpdateJournals();
            _newspaperModel.UpdateNewspapers();
        }
    }
}
