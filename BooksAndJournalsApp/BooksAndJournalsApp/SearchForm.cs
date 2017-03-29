using System;
using Presenters;
using System.Windows.Forms;
using Views;

namespace Forms
{
    public partial class SearchForm : Form, ISearchView
    {
        private SearchPresenter _presenter;

        public SearchForm()
        {
            InitializeComponent();

            _presenter = new SearchPresenter(this);
            DGVAuthors.DataSource = _presenter.GetAllAuthors();
            DGVAuthors.Columns["Id"].Visible = false;
        }

        private void DGVAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LstBoxSearchResultsView.DataSource = _presenter.FindAuthorsWorks(Int32.Parse(DGVAuthors.CurrentRow.Cells["Id"].Value.ToString()));
        }
    }
}
