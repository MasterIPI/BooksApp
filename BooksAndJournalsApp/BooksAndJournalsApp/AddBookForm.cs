using System;
using System.Windows.Forms;
using Presenters;
using Views;

namespace Forms
{
    public partial class AddBookForm : Form, IBookAdd
    {
        private string _title;
        private string _author;
        private int _yearOfBirth;
        private AddBookPresenter _presenter;

        public AddBookForm()
        {
            _presenter = new AddBookPresenter(this);
            InitializeComponent();
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

        private void AddBook(object sender, EventArgs e)
        {
            ShowWarning();

            Title = BoxTitle.Text;
            Author = BoxAuthor.Text;
            YearOfBirth = Int32.Parse(BoxYear.Text);

            _presenter.AddBook();

            BoxAuthor.Text = string.Empty;
            BoxYear.Text = string.Empty;

        }

        private void BoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ShowWarning()
        {
            if (BoxAuthor.Text == string.Empty || BoxTitle.Text == string.Empty || BoxYear.Text == string.Empty)
            {
                MessageBox.Show("All of the fields must be not empty!", "Warning!!!");
            }
        }
    }
}
