using Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;

namespace Presenters
{
    public class DeleteJournalPresenter
    {
        private JournalModel _journalModel;
        private IDeleJournalView _view;

        public DeleteJournalPresenter(IDeleJournalView View)
        {
            _view = View;
            _journalModel = new JournalModel();
        }

        public void DeleteRowBtnClick()
        {
            _journalModel.RemoveFromJournals((int)_view.CurrentRow.Cells["Id"].Value);
            _view.Journals.Remove((Journal)_view.CurrentRow.DataBoundItem);
        }
    }
}
