using Models;
using Views;
using AdditionalDataProvider;

namespace Presenters
{
    public class AddJournalPresenter
    {
        private JournalModel _journalModel;
        private IJournalAdd _view;

        public AddJournalPresenter(IJournalAdd View)
        {
            _journalModel = new JournalModel();
            _view = View;
        }

        public void AddJournal()
        {
            _journalModel.AddJournal(_view.Title, _view.Author, _view.YearOfBirth, _view.Article);
        }
    }
}
