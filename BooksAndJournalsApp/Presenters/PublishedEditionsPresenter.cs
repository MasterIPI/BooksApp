using Models;
using View;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Presenters
{
    public class PublishedEditionsPresenter
    {
        private PublishedEditionsModel _model;
        private IMainView _view;

        public PublishedEditionsPresenter(IMainView view)
        {
            _model = new PublishedEditionsModel();
            _view = view;
        }

        public List<string> GetListDataSources()
        {
            return _model.dataSources;
        }

        public void OnSaveViewSaveBtnClick(string booksSaveOption, string journalsSaveOption, string newspapersSaveOption)
        {
            _view.ShowError(_model.Serialize(_model.books, booksSaveOption));
            _view.ShowError(_model.Serialize(_model.journals, journalsSaveOption));
            _view.ShowError(_model.Serialize(_model.newspapers, newspapersSaveOption));
        }

        public List<object> FindAuthorsWorks(string author, int yearofbirth)
        {
            List<object> result = (from row in _model.FindAuthorsWorks(author, yearofbirth).AsEnumerable() select (row["Title"])).ToList();

            return result;
        }

        public DataTable GetAllAuthors()
        {
            return _model.GetAllAuthors();
        }

        public DataTable GetContentFromName(string contentType)
        {
            if (contentType == "Book")
            {
                return _model.books;
            }

            if (contentType == "Journal")
            {
                return _model.journals;
            }

            if (contentType == "Newspaper")
            {
                return _model.newspapers;
            }

            return null;
        }

        public void OnDeleteViewsDltRowBtnClick(DataGridViewRow Row, string ContentType)
        {
            if (ContentType == "Book")
            {
                _model.RemoveFromBooks(Row.Cells["Book"].Value.ToString());
            }

            if (ContentType == "Journal")
            {
                _model.RemoveFromJournals(Row.Cells["Journal"].Value.ToString());
            }

            if (ContentType == "Newspaper")
            {
                _model.RemoveFromNewspapers(Row.Cells["Newspaper"].Value.ToString(), Row.Cells["Publisher"].Value.ToString());
            }
        }

        public void AddBook(string title, string author, int yearofbirth)
        {
            _model.AddBook(title, author, yearofbirth);
        }

        public void AddJournal(string title, string author, int yearofbirth, string article)
        {
            _model.AddJournal(title, author, yearofbirth, article);
        }

        public void AddNewspaper(string title, string publisher,  string article)
        {
            _model.AddNewspaper(title, publisher, article);
        }

        public void UpdateData()
        {
            _model.UpdateData();
        }
    }
}
