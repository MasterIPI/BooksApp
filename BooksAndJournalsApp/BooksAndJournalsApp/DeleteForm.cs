using System;
using System.Windows.Forms;
using Presenters;
using Views;
using System.Collections.Generic;
using Entities;
using Enums;

namespace Forms
{
    public partial class DeleteForm : Form, IDeleteView
    {
        private List<Book> _books = new List<Book>();
        private List<Journal> _journals = new List<Journal>();
        private List<Newspaper> _newspapers = new List<Newspaper>();
        private DataGridViewRow _currentRow;
        private ContentType _type;
        private DeletePresenter _presenter;

        public ContentType Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public DataGridViewRow CurrentRow
        {
            get
            {
                return _currentRow;
            }

            set
            {
                _currentRow = value;
            }
        }

        public List<Book> Books
        {
            get
            {
                return _books;
            }

            set
            {
                _books = value;
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
                _journals = value;
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
                _newspapers = value;
            }
        }

        public DeleteForm(ref List<Book> books)
        {
            _presenter = new DeletePresenter(this);
            Books = books;
            Type = ContentType.Book;

            InitializeComponent();

            UpdateView();
        }

        public DeleteForm(ref List<Journal> journals)
        {
            _presenter = new DeletePresenter(this);
            Journals = journals;
            Type = ContentType.Journal;

            InitializeComponent();

            UpdateView();
        }

        public DeleteForm(ref List<Newspaper> newspapers)
        {
            _presenter = new DeletePresenter(this);
            Newspapers = newspapers;
            Type = ContentType.Newspaper;

            InitializeComponent();

            UpdateView();
        }

        private void BtnDeleteRow_Click(object sender, EventArgs e)
        {
            if (DGVContentViewer.CurrentRow.DataBoundItem != null)
            {
                CurrentRow = DGVContentViewer.CurrentRow;
                _presenter.DeleteRowBtnClick();
                UpdateView();
            }
        }

        public void UpdateView()
        {
            DGVContentViewer.DataSource = null;

            if (Type == ContentType.Book)
            {
                DGVContentViewer.DataSource = Books;
            }

            if (Type == ContentType.Journal)
            {
                DGVContentViewer.DataSource = Journals;
            }

            if (Type == ContentType.Newspaper)
            {
                DGVContentViewer.DataSource = Newspapers;
            }
            
            DGVContentViewer.Columns["Id"].Visible = false;
        }
    }
}
