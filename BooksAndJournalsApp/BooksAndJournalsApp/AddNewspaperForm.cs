using System;
using Presenters;
using Views;
using System.Windows.Forms;
using Entities;
using System.Collections.Generic;

namespace Forms
{
    public partial class AddNewspaperForm : Form, INewspaperAdd
    {
        private string _title;
        private string _publisher;
        private string _article;
        private AddNewspaperPresenter _presenter;

        public AddNewspaperForm()
        {
            InitializeComponent();
            _presenter = new AddNewspaperPresenter(this);
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

        public string Publisher
        {
            get
            {
                return _publisher;
            }

            set
            {
                _publisher = value;
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

        private void AddNewspaper(object sender, EventArgs e)
        {
            if (BoxPublisher.Text == string.Empty || BoxTitle.Text == string.Empty || BoxArticle.Text == string.Empty)
            {
                MessageBox.Show("All of the fields must be not empty!", "Warning!!!");
            }

            else
            {
                Title = BoxTitle.Text;
                Publisher = BoxPublisher.Text;
                Article = BoxArticle.Text;

                _presenter.AddNewspaper();

                BoxArticle.Text = string.Empty;
            }
        }
    }
}
