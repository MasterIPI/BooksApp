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
    public class DeleteNewspaperPresenter
    {
        private NewspaperModel _newspaperModel;
        private IDeleteNewspaperView _view;

        public DeleteNewspaperPresenter(IDeleteNewspaperView View)
        {
            _view = View;
            _newspaperModel = new NewspaperModel();
        }

        public void DeleteRowBtnClick()
        {
            _newspaperModel.RemoveFromNewspapers((int)_view.CurrentRow.Cells["Id"].Value);
            _view.Newspapers.Remove((Newspaper)_view.CurrentRow.DataBoundItem);
        }
    }
}
