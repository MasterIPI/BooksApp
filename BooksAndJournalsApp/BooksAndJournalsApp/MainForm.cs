using Entities;
using Presenters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View;

namespace Forms
{
    public partial class MainForm : Form, IMainView
    {
        private PublishedEditionsPresenter presenter;

        public MainForm()
        {
            InitializeComponent();
            presenter = new PublishedEditionsPresenter(this);
            containerBox.DataSource = presenter.GetListDataSources();
        }

        private void authorsWorksBtn_Click(object sender, EventArgs e)
        {
            using (SearchForm form = new SearchForm(presenter))
            {
                form.ShowDialog();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (SaveForm saveForm = new SaveForm(presenter))
            {
                saveForm.ShowDialog();
            }
        }

        private void containerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateViewedData();
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            using (DeleteForm dltForm = new DeleteForm(containerBox.SelectedItem.ToString(), presenter))
            {
                dltForm.ShowDialog();
            }

            presenter.UpdateData();
            UpdateViewedData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (AddForm addForm = new AddForm(containerBox.SelectedItem.ToString(), presenter))
            {
                addForm.ShowDialog();
            }

            presenter.UpdateData();
            UpdateViewedData();
        }

        public void UpdateViewedData()
        {
            AuthorsGV.DataSource = null;
            ArticleBox.DataSource = null;
            ContainerViewer.DataSource = null;
            ContainerViewer.DataSource = presenter.GetContentFromName(containerBox.SelectedItem.ToString());
        }

        private void ContainerViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AuthorsGV.DataSource = null;
            ArticleBox.DataSource = null;

            if (containerBox.SelectedItem.ToString() == "Book")
            {
                List<Book> books = (List<Book>)ContainerViewer.DataSource;
                AuthorsGV.DataSource = books[ContainerViewer.CurrentRow.Index].Authors;
            }

            if (containerBox.SelectedItem.ToString() == "Journal")
            {
                List<Journal> journals = (List<Journal>)ContainerViewer.DataSource;
                ArticleBox.DataSource = journals[ContainerViewer.CurrentRow.Index].Articles;
            }

            if (containerBox.SelectedItem.ToString() == "Newspaper")
            {
                List<Newspaper> newspapers = (List<Newspaper>)ContainerViewer.DataSource;
                ArticleBox.DataSource = newspapers[ContainerViewer.CurrentRow.Index].Articles;
            }
        }

        private void ArticleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (containerBox.SelectedItem.ToString() == "Journal")
            {
                List<JournalArticle> articles = (List<JournalArticle>)ArticleBox.DataSource;
                if (ArticleBox.SelectedIndex >= 0)
                {
                    AuthorsGV.DataSource = articles[ArticleBox.SelectedIndex].Authors;
                }
            }
        }

        
    }
}
