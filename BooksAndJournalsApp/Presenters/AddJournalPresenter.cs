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

        public void AddJournal(string title, string author, int yearofbirth, string article)
        {
            _journalModel.AddJournal(title, author, yearofbirth, article);
        }
    }
}
