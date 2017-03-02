using BooksAndJournalsApp.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BooksAndJournalsApp
{
    public partial class DeleteView : Form
    {
        private PublishedEditionsPresenter _presenter;
        private string _contentType;

        public DeleteView(string contentType, PublishedEditionsPresenter presenter)
        {
            _presenter = presenter;
            _contentType = contentType;

            InitializeComponent();

            UpdateView();
        }

        private void dltRowBtn_Click(object sender, EventArgs e)
        {
            if (ContentViewer.CurrentRow.DataBoundItem != null)
            {
                _presenter.OnDeleteViewsDltRowBtnClick(ContentViewer.CurrentRow.DataBoundItem);
                UpdateView();
            }
        }

        private void UpdateView()
        {
            ContentViewer.DataSource = typeof(List<>);
            ContentViewer.DataSource = _presenter.GetContentFromName(_contentType);
        }
    }
}
