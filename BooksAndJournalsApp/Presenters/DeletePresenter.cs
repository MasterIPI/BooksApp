using Enums;
using System.Windows.Forms;
using Views;
using Models;
using Entities;

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

        public void DeleteRowBtnClick()
        {
            if (_view.Type == ContentType.Book)
            {
                _bookModel.RemoveFromBooks((int)_view.CurrentRow.Cells["Id"].Value);
                _view.Books.Remove((Book)_view.CurrentRow.DataBoundItem);
            }

            if (_view.Type == ContentType.Journal)
            {
                _journalModel.RemoveFromJournals((int)_view.CurrentRow.Cells["Id"].Value);
                _view.Journals.Remove((Journal)_view.CurrentRow.DataBoundItem);
            }

            if (_view.Type == ContentType.Newspaper)
            {
                _newspaperModel.RemoveFromNewspapers((int)_view.CurrentRow.Cells["Id"].Value);
                _view.Newspapers.Remove((Newspaper)_view.CurrentRow.DataBoundItem);
            }
        }
    }
}
