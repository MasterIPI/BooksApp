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
            _bookModel = BookModel.GetInstance();
            _journalModel = JournalModel.GetInstance();
            _newspaperModel = NewspaperModel.GetInstance();
        }

        public void OnDeleteViewsDltRowBtnClick(DataGridViewRow Row, ContentType Type)
        {
            if (Type == ContentType.Book)
            {
                _bookModel.RemoveFromBooks(Row);
            }

            if (Type == ContentType.Journal)
            {
                _journalModel.RemoveFromJournals(Row);
            }

            if (Type == ContentType.Newspaper)
            {
                _newspaperModel.RemoveFromNewspapers(Row);
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
