using System;
using System.Drawing;
using System.Windows.Forms;
using Presenters;
using Views;

namespace Forms
{
    public partial class AddBookForm : Form, IBookAdd
    {
        private AddBookPresenter _presenter;

        public AddBookForm()
        {
            _presenter = new AddBookPresenter(this);
            InitializeComponent();
        }

        private void AddBook(object sender, EventArgs e)
        {
            if (BoxAuthor.Text == string.Empty || BoxTitle.Text == string.Empty || BoxYear.Text == string.Empty)
            {
                MessageBox.Show("All of the fields must be not empty!", "Warning!!!");
            }

            else
            {
                _presenter.AddBook(BoxTitle.Text, BoxAuthor.Text, Int32.Parse(BoxYear.Text));

                BoxAuthor.Text = string.Empty;
                BoxYear.Text = string.Empty;
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
