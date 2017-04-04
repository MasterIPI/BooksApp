using System;
using Presenters;
using System.Windows.Forms;
using Views;

namespace Forms
{
    public partial class SearchForm : Form, ISearchView
    {
        private int _authorId;
        private SearchPresenter _presenter;

        public SearchForm()
        {
            InitializeComponent();

            _presenter = new SearchPresenter(this);
            DGVAuthors.DataSource = _presenter.GetAllAuthors();
            DGVAuthors.Columns["Id"].Visible = false;
        }

        public int AuthorId
        {
            get
            {
                return _authorId;
            }

            set
            {
                _authorId = value;
            }
        }

        private void DGVAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AuthorId = Int32.Parse(DGVAuthors.CurrentRow.Cells["Id"].Value.ToString());
            LstBoxSearchResultsView.DataSource = _presenter.FindAuthorsWorks();
        }
    }
}
