using System;
using System.Windows.Forms;
using Presenters;

namespace Forms
{
    public partial class DeleteForm : Form
    {
        private PublishedEditionsPresenter _presenter;
        private string _contentType;

        public DeleteForm(string contentType, PublishedEditionsPresenter presenter)
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
                _presenter.OnDeleteViewsDltRowBtnClick(ContentViewer.CurrentRow, _contentType);
                UpdateView();
            }
        }

        private void UpdateView()
        {
            ContentViewer.DataSource = null;
            ContentViewer.DataSource = _presenter.GetContentFromName(_contentType);
        }
    }
}
