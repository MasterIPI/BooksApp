using System;
using Presenters;
using Views;
using System.Windows.Forms;

namespace Forms
{
    public partial class AddNewspaperForm : Form, INewspaperAdd
    {
        private AddNewspaperPresenter _presenter;
        public AddNewspaperForm()
        {
            InitializeComponent();
            _presenter = new AddNewspaperPresenter(this);
        }

        private void AddNewspaper(object sender, EventArgs e)
        {
            if (BoxPublisher.Text == string.Empty || BoxTitle.Text == string.Empty || BoxArticle.Text == string.Empty)
            {
                MessageBox.Show("All of the fields must be not empty!", "Warning!!!");
            }

            else
            {
                _presenter.AddNewspaper(BoxTitle.Text, BoxPublisher.Text, BoxArticle.Text);

                BoxArticle.Text = string.Empty;
            }
        }
    }
}
