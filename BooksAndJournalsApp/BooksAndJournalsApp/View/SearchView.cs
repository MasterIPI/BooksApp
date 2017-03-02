using BooksAndJournalsApp.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksAndJournalsApp
{
    public partial class SearchView : Form
    {
        private PublishedEditionsPresenter _presenter;
        private List<string> results = new List<string>();


        public SearchView(PublishedEditionsPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            AuthorsBox.DataSource = presenter.GetAllAuthors().ToList();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchResultsView.DataSource = _presenter.OnSearchViewSearchBtnClick(AuthorsBox.SelectedItem.ToString());
        }

        private void AuthorsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBtn.Enabled = true;
        }
    }
}
