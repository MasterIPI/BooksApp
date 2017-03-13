using System;
using System.Collections.Generic;
using Presenters;
using System.Windows.Forms;

namespace Forms
{
    public partial class SearchForm : Form
    {
        private PublishedEditionsPresenter _presenter;
        private List<string> results = new List<string>();


        public SearchForm(PublishedEditionsPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            AuthorsGV.DataSource = presenter.GetAllAuthors();
        }

        private void AuthorsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            searchResultsView.DataSource = _presenter.FindAuthorsWorks(AuthorsGV.CurrentRow.Cells["Name"].Value.ToString(), Int32.Parse(AuthorsGV.CurrentRow.Cells["YearOfBirth"].Value.ToString()));
        }
    }
}
