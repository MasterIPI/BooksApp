using System;
using Views;
using Presenters;
using System.Windows.Forms;

namespace Forms
{
    public partial class AddJournalForm : Form, IJournalAdd
    {
        private string _title;
        private string _author;
        private int _yearOfBirth;
        private string _article;
        private AddJournalPresenter _presenter;

        public AddJournalForm()
        {
            InitializeComponent();
            _presenter = new AddJournalPresenter(this);
        }

        public string Article
        {
            get
            {
                return _article;
            }

            set
            {
                _article = value;
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }

            set
            {
                _author = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public int YearOfBirth
        {
            get
            {
                return _yearOfBirth;
            }

            set
            {
                _yearOfBirth = value;
            }
        }

        private void AddJournal(object sender, EventArgs e)
        {
            if (BoxAuthor.Text == string.Empty || BoxTitle.Text == string.Empty || BoxArticle.Text == string.Empty || BoxYear.Text == string.Empty)
            {
                MessageBox.Show("All of the fields must be not empty!", "Warning!!!");
            }

            else
            {
                Title = BoxTitle.Text;
                Author = BoxAuthor.Text;
                YearOfBirth = Int32.Parse(BoxYear.Text);
                Article = BoxArticle.Text;

                _presenter.AddJournal();

                BoxArticle.Text = string.Empty;
            }
        }

        private void BoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
