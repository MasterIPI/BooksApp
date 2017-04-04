using Views;
using Models;

namespace Presenters
{
    public class SavePresenter
    {
        private ISaveView _view;
        private BookModel _bookModel;
        private JournalModel _journalModel;
        private NewspaperModel _newspaperModel;

        public SavePresenter(ISaveView View)
        {
            _view = View;
            _bookModel = new BookModel();
            _journalModel = new JournalModel();
            _newspaperModel = new NewspaperModel();
        }

        public void SaveViewBtnSaveClick()
        {
            _bookModel.Serialize(_view.SaveBooksOption, _view.Books);
            _journalModel.Serialize(_view.SaveJournalsOption, _view.Journals);
            _newspaperModel.Serialize(_view.SaveNewspapersOption, _view.Newspapers);
        }
    }
}
