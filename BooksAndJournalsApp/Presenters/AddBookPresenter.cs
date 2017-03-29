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

        public void AddBook(string title, string author, int yearofbirth)
        {
            _bookModel.AddBook(title, author, yearofbirth);
        }
    }
}
