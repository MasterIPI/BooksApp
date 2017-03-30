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
        private DeletePresenter _presenter;
        private List<Book> _books;
        private List<Journal> _journals;
        private List<Newspaper> _newspapers;
        private ContentType _type;

        public DeleteForm(List<Book> Books)
        {
            _presenter = new DeletePresenter(this);
            _books = Books;
            _type = ContentType.Book;

            InitializeComponent();

            UpdateView();
        }

        public DeleteForm(List<Journal> Journals)
        {
            _presenter = new DeletePresenter(this);
            _journals = Journals;
            _type = ContentType.Journal;

            InitializeComponent();

            UpdateView();
        }

        public DeleteForm(List<Newspaper> Newspapers)
        {
            _presenter = new DeletePresenter(this);
            _newspapers = Newspapers;
            _type = ContentType.Newspaper;

            InitializeComponent();

            UpdateView();
        }

        private void BtnDeleteRow_Click(object sender, EventArgs e)
        {
            if (DGVContentViewer.CurrentRow.DataBoundItem != null)
            {
                _presenter.OnDeleteViewsDltRowBtnClick(DGVContentViewer.CurrentRow, _type);
                UpdateView();
            }
        }

        public void UpdateView()
        {
            DGVContentViewer.DataSource = null;
            DGVContentViewer.DataSource = _presenter.GetContentFromName(_type.ToString());
            DGVContentViewer.Columns["Id"].Visible = false;
        }
    }
}
