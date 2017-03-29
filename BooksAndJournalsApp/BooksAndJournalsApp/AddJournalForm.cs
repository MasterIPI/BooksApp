using System;
using Views;
using Presenters;
using System.Windows.Forms;

namespace Forms
{
    public partial class AddJournalForm : Form, IJournalAdd
    {
        private AddJournalPresenter _presenter;

        public AddJournalForm()
        {
            InitializeComponent();
            _presenter = new AddJournalPresenter(this);
        }

        private void AddJournal(object sender, EventArgs e)
        {
            if (BoxAuthor.Text == string.Empty || BoxTitle.Text == string.Empty || BoxArticle.Text == string.Empty || BoxYear.Text == string.Empty)
            {
                MessageBox.Show("All of the fields must be not empty!", "Warning!!!");
            }

            else
            {
                _presenter.AddJournal(BoxTitle.Text, BoxAuthor.Text, Int32.Parse(BoxYear.Text), BoxArticle.Text);

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
