using Enums;
using System.Windows.Forms;
using Views;
using Models;
using Entities;

namespace Presenters
{
    public class DeleteBookPresenter
    {
        private BookModel _bookModel;
        private IDeleteBookView _view;

        public DeleteBookPresenter(IDeleteBookView View)
        {
            _view = View;
            _bookModel = new BookModel();
        }

        public void DeleteRowBtnClick()
        {
            _bookModel.RemoveFromBooks((int)_view.CurrentRow.Cells["Id"].Value);
            _view.Books.Remove((Book)_view.CurrentRow.DataBoundItem);
        }
    }
}
