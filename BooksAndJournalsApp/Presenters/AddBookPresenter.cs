using Models;
using Views;
using AdditionalDataProvider;

namespace Presenters
{
    public class AddBookPresenter
    {
        private BookModel _bookModel;
        private IBookAdd _view;

        public AddBookPresenter(IBookAdd View)
        {
            _bookModel = new BookModel();
            _view = View;
        }

        public void AddBook()
        {
            _bookModel.AddBook(_view.Title, _view.Author, _view.YearOfBirth);
        }
    }
}
