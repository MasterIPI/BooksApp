using Enums;
using System.Windows.Forms;
using Views;
using Models;

namespace Presenters
{
    public class DeletePresenter
    {
        private BookModel _bookModel;
        private JournalModel _journalModel;
        private NewspaperModel _newspaperModel;
        private IDeleteView _view;

        public DeletePresenter(IDeleteView View)
        {
            _view = View;
            _bookModel = new BookModel();
            _journalModel = new JournalModel();
            _newspaperModel = new NewspaperModel();
        }

        public void OnDeleteViewsDltRowBtnClick(DataGridViewRow Row, string contentType)
        {
            if (contentType == ContentType.Book.ToString())
            {
                _bookModel.RemoveFromBooks(Row.Cells["Title"].Value.ToString());
            }

            if (contentType == ContentType.Journal.ToString())
            {
                _journalModel.RemoveFromJournals(Row.Cells["Title"].Value.ToString());
            }

            if (contentType == ContentType.Newspaper.ToString())
            {
                _newspaperModel.RemoveFromNewspapers(Row.Cells["Title"].Value.ToString(), Row.Cells["Publisher"].Value.ToString());
            }
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
    }
}
