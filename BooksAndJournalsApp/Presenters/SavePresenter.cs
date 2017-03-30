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
            _bookModel = BookModel.GetInstance();
            _journalModel = JournalModel.GetInstance();
            _newspaperModel = NewspaperModel.GetInstance();
        }

        public void OnSaveViewSaveBtnClick(string booksSaveOption, string journalsSaveOption, string newspapersSaveOption)
        {
            _bookModel.Serialize(booksSaveOption);
            _journalModel.Serialize(journalsSaveOption);
            _newspaperModel.Serialize(newspapersSaveOption);
        }
    }
}
