using Entities;
using AdditionalDataProvider;
using Presenters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Views;
using Enums;

namespace Forms
{
    public partial class MainForm : Form, IMainView
    {
        private MainPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();
            _presenter = new MainPresenter(this);
            DropBoxTypes.DataSource = _presenter.GetListDataSources();
        }

        private void BtnAuthorsWorks_Click(object sender, EventArgs e)
        {
            using (SearchForm form = new SearchForm())
            {
                form.ShowDialog();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (SaveForm saveForm = new SaveForm())
            {
                saveForm.ShowDialog();
            }
        }

        private void DropBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateViewedData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (DeleteForm dltForm = new DeleteForm(_presenter.GetContentFromName(DropBoxTypes.SelectedItem.ToString())))
            {
                dltForm.ShowDialog();
            }

            UpdateViewedData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Book.ToString())
            {
                using (AddBookForm addForm = new AddBookForm())
                {
                    addForm.ShowDialog();
                }
            }

            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Journal.ToString())
            {
                using (AddJournalForm addForm = new AddJournalForm())
                {
                    addForm.ShowDialog();
                }
            }

            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Newspaper.ToString())
            {
                using (AddNewspaperForm addForm = new AddNewspaperForm())
                {
                    addForm.ShowDialog();
                }
            }

            _presenter.UpdateData();
            UpdateViewedData();
        }

        public void UpdateViewedData()
        {
            DGVAuthorsViewer.DataSource = null;
            LstBoxArticle.DataSource = null;
            DGVPublishedEditionViewer.DataSource = null;
            DGVPublishedEditionViewer.DataSource = _presenter.GetContentFromName(DropBoxTypes.SelectedItem.ToString());
            DGVPublishedEditionViewer.Columns["Id"].Visible = false;
        }

        private void LstBoxArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Journal.ToString())
            {
                List<JournalArticle> articles = (List<JournalArticle>)LstBoxArticle.DataSource;
                if (LstBoxArticle.SelectedIndex >= 0)
                {
                    DGVAuthorsViewer.DataSource = articles[LstBoxArticle.SelectedIndex].Authors;
                    DGVAuthorsViewer.Columns["Id"].Visible = false;
                }
            }
        }

        private void DGVPublishedEditionViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVAuthorsViewer.DataSource = null;
            LstBoxArticle.DataSource = null;

            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Book.ToString())
            {
                List<Book> books = (List<Book>)DGVPublishedEditionViewer.DataSource;
                DGVAuthorsViewer.DataSource = books[DGVPublishedEditionViewer.CurrentRow.Index].Authors;
                DGVAuthorsViewer.Columns["Id"].Visible = false;
            }

            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Journal.ToString())
            {
                List<Journal> journals = (List<Journal>)DGVPublishedEditionViewer.DataSource;
                LstBoxArticle.DataSource = journals[DGVPublishedEditionViewer.CurrentRow.Index].Articles;
            }

            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Newspaper.ToString())
            {
                List<Newspaper> newspapers = (List<Newspaper>)DGVPublishedEditionViewer.DataSource;
                LstBoxArticle.DataSource = newspapers[DGVPublishedEditionViewer.CurrentRow.Index].Articles;
            }
        }
    }
}
