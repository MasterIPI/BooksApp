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

        public void AddNewspaper()
        {
            _newspaperModel.AddNewspaper(_view.Title, _view.Publisher, _view.Article);
        }
    }
}
