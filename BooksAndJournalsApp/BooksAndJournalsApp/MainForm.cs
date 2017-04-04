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

        private List<Book> _books = new List<Book>();
        private List<Journal> _journals = new List<Journal>();
        private List<Newspaper> _newspapers = new List<Newspaper>();

        public List<Book> Books
        {
            get
            {
                return _books;
            }

            set
            {
                _books.AddRange(value);
            }
        }

        public List<Journal> Journals
        {
            get
            {
                return _journals;
            }

            set
            {
                _journals.AddRange(value);
            }
        }

        public List<Newspaper> Newspapers
        {
            get
            {
                return _newspapers;
            }

            set
            {
                _newspapers.AddRange(value);
            }
        }

        public MainForm()
        {
            InitializeComponent();

            _presenter = new MainPresenter(this);
            _presenter.UpdateData();
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
            CallSaveView();
        }

        private void DropBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateViewedData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            CallDeleteView();

            UpdateViewedData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Book.ToString())
            {
                CallAddBookView();
            }

            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Journal.ToString())
            {
                CallAddJournalView();
            }

            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Newspaper.ToString())
            {
                CallAddNewspaperView();
            }

            _presenter.UpdateData();
            UpdateViewedData();
        }

        public void UpdateViewedData()
        {
            DGVAuthorsViewer.DataSource = null;
            LstBoxArticle.DataSource = null;
            DGVPublishedEditionViewer.DataSource = null;

            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Book.ToString())
            {
                DGVPublishedEditionViewer.DataSource = Books;
            }

            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Journal.ToString())
            {
                DGVPublishedEditionViewer.DataSource = Journals;
            }

            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Newspaper.ToString())
            {
                DGVPublishedEditionViewer.DataSource = Newspapers;
            }
            
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

        public void CallDeleteView()
        {
            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Book.ToString())
            {
                using (DeleteForm dltForm = new DeleteForm(ref _books))
                {
                    dltForm.ShowDialog();
                }
            }

            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Journal.ToString())
            {
                using (DeleteForm dltForm = new DeleteForm(ref _journals))
                {
                    dltForm.ShowDialog();
                }
            }

            if (DropBoxTypes.SelectedItem.ToString() == ContentType.Newspaper.ToString())
            {
                using (DeleteForm dltForm = new DeleteForm(ref _newspapers))
                {
                    dltForm.ShowDialog();
                }
            }

            UpdateViewedData();
        }

        public void CallAddBookView()
        {
            using (AddBookForm addForm = new AddBookForm())
            {
                addForm.ShowDialog();
            }
        }

        public void CallAddJournalView()
        {
            using (AddJournalForm addForm = new AddJournalForm())
            {
                addForm.ShowDialog();
            }
        }

        public void CallAddNewspaperView()
        {
            using (AddNewspaperForm addForm = new AddNewspaperForm())
            {
                addForm.ShowDialog();
            }
        }

        public void CallSaveView()
        {
            using (SaveForm saveForm = new SaveForm(Books, Journals, Newspapers))
            {
                saveForm.ShowDialog();
            }
        }
    }
}
