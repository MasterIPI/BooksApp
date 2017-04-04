using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Presenters;
using AdditionalDataProvider;
using Views;
using Entities;

namespace Forms
{
    public partial class SaveForm : Form, ISaveView
    {
        private List<Book> _books;
        private List<Journal> _journals;
        private List<Newspaper> _newspapers;
        private string _saveBooksOption;
        private string _saveJournalsOption;
        private string _saveNewspapersOption;
        private SavePresenter _presenter;

        public SaveForm(List<Book> books, List<Journal> journals, List<Newspaper> newspapers)
        {
            _presenter = new SavePresenter(this);

            InitializeComponent();

            Books = books;
            Journals = journals;
            Newspapers = newspapers;

            DrpBoxBooks.Items.AddRange(SaveOption.saveFileOptions.ToArray());
            DrpBoxJournals.Items.AddRange(SaveOption.saveFileOptions.ToArray());
            DrpBoxNewspapers.Items.AddRange(SaveOption.saveFileOptions.ToArray());
        }

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

        public string SaveBooksOption
        {
            get
            {
                return _saveBooksOption;
            }

            set
            {
                _saveBooksOption = value;
            }
        }

        public string SaveJournalsOption
        {
            get
            {
                return _saveJournalsOption;
            }

            set
            {
                _saveJournalsOption = value;
            }
        }

        public string SaveNewspapersOption
        {
            get
            {
                return _saveNewspapersOption;
            }

            set
            {
                _saveNewspapersOption = value;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveBooksOption = DrpBoxBooks.SelectedItem.ToString();
            SaveJournalsOption = DrpBoxJournals.SelectedItem.ToString();
            SaveNewspapersOption = DrpBoxNewspapers.SelectedItem.ToString();

            _presenter.SaveViewBtnSaveClick();
        }

        private void EnableBtnSave(object sender, EventArgs e)
        {
            if (DrpBoxBooks.Text != string.Empty && DrpBoxJournals.Text != string.Empty && DrpBoxNewspapers.Text != string.Empty)
            {
                BtnSave.Enabled = true;
            }
        }
    }
}
