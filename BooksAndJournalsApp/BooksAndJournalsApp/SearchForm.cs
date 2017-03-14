using System;
using System.Collections.Generic;
using Presenters;
using System.Windows.Forms;
using Entities;

namespace Forms
{
    public partial class SearchForm : Form
    {
        private PublishedEditionsPresenter _presenter;

        public SearchForm(PublishedEditionsPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();
            
            AuthorsGV.DataSource = presenter.GetAllAuthors();
            AuthorsGV.Columns["Id"].Visible = false;
        }

        private void AuthorsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            searchResultsView.DataSource = _presenter.FindAuthorsWorks(AuthorsGV.CurrentRow.Cells["Name"].Value.ToString(), Int32.Parse(AuthorsGV.CurrentRow.Cells["YearOfBirth"].Value.ToString()));
        }
    }
}
