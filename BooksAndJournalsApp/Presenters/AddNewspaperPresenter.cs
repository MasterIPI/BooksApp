using Models;
using Views;
using AdditionalDataProvider;

namespace Presenters
{
    public class AddNewspaperPresenter
    {
        private NewspaperModel _newspaperModel;
        private INewspaperAdd _view;

        public AddNewspaperPresenter(INewspaperAdd View)
        {
            _newspaperModel = new NewspaperModel();
            _view = View;
        }

        public void AddNewspaper(string title, string publisher, string article)
        {
            _newspaperModel.AddNewspaper(title, publisher, article);
        }
    }
}
