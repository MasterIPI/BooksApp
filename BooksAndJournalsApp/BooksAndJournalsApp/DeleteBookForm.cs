using System;
using System.Windows.Forms;
using Presenters;
using Views;
using System.Collections.Generic;
using Entities;

namespace Forms
{
    public partial class DeleteBookForm : Form, IDeleteBookView
    {
        private List<Book> _books = new List<Book>();
        private DataGridViewRow _currentRow;
        private DeleteBookPresenter _presenter;

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

        public DeleteBookForm(ref List<Book> books)
        {
            _presenter = new DeleteBookPresenter(this);
            _books = books;

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
            DGVContentViewer.DataSource = Books;
            DGVContentViewer.Columns["Id"].Visible = false;
        }
    }
}
