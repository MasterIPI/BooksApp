using System;
using System.Windows.Forms;
using Presenters;
using Views;

namespace Forms
{
    public partial class DeleteForm : Form, IDeleteView
    {
        private DeletePresenter _presenter;
        private string _contentType;

        public DeleteForm(string contentType)
        {
            _presenter = new DeletePresenter(this);
            _contentType = contentType;

            InitializeComponent();

            UpdateView();
        }

        private void BtnDeleteRow_Click(object sender, EventArgs e)
        {
            if (DGVContentViewer.CurrentRow.DataBoundItem != null)
            {
                _presenter.OnDeleteViewsDltRowBtnClick(DGVContentViewer.CurrentRow, _contentType);
                UpdateView();
            }
        }

        public void UpdateView()
        {
            DGVContentViewer.DataSource = null;
            DGVContentViewer.DataSource = _presenter.GetContentFromName(_contentType);
            DGVContentViewer.Columns["Id"].Visible = false;
        }
    }
}
