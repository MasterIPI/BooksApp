using Models;
using View;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Entities;

namespace Presenters
{
    public class PublishedEditionsPresenter
    {
        private MainModel _model;
        private IMainView _view;

        public PublishedEditionsPresenter(IMainView view)
        {
            _model = new MainModel();
            _view = view;
        }

        public List<string> GetListDataSources()
        {
            return _model.dataSources;
        }

        public void OnSaveViewSaveBtnClick(string booksSaveOption, string journalsSaveOption, string newspapersSaveOption)
        {
            _model._bookModel.Serialize(booksSaveOption);
            _model._journalModel.Serialize(journalsSaveOption);
            _model._newspaperModel.Serialize(newspapersSaveOption);
        }

        public List<string> FindAuthorsWorks(string author, int yearofbirth)
        {
            return _model.FindAuthorsWorks(author,yearofbirth);
        }

        public List<Author> GetAllAuthors()
        {
            return _model.GetAllAuthors();
        }

        public dynamic GetContentFromName(string contentType)
        {
            if (contentType == "Book")
            {
                return _model._bookModel.books;
            }

            if (contentType == "Journal")
            {
                return _model._journalModel.journals;
            }

            if (contentType == "Newspaper")
            {
                return _model._newspaperModel.newspapers;
            }

            return null;
        }

        public void OnDeleteViewsDltRowBtnClick(DataGridViewRow Row, string ContentType)
        {
            if (ContentType == "Book")
            {
                _model._bookModel.RemoveFromBooks(Row.Cells["Title"].Value.ToString());
            }

            if (ContentType == "Journal")
            {
                _model._journalModel.RemoveFromJournals(Row.Cells["Title"].Value.ToString());
            }

            if (ContentType == "Newspaper")
            {
                _model._newspaperModel.RemoveFromNewspapers(Row.Cells["Title"].Value.ToString(), Row.Cells["Publisher"].Value.ToString());
            }
        }

        public void AddBook(string title, string author, int yearofbirth)
        {
            _model._bookModel.AddBook(title, author, yearofbirth);
        }

        public void AddJournal(string title, string author, int yearofbirth, string article)
        {
            _model._journalModel.AddJournal(title, author, yearofbirth, article);
        }

        public void AddNewspaper(string title, string publisher,  string article)
        {
            _model._newspaperModel.AddNewspaper(title, publisher, article);
        }

        public void UpdateData()
        {
            _model.UpdateData();
        }
    }
}
