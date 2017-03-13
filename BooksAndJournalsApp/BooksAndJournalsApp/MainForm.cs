using Presenters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View;

namespace Forms
{
    public partial class MainForm : Form, IMainView
    {
        private PublishedEditionsPresenter presenter;

        public MainForm()
        {
            InitializeComponent();
            presenter = new PublishedEditionsPresenter(this);
            containerBox.DataSource = presenter.GetListDataSources();
        }

        private void authorsWorksBtn_Click(object sender, EventArgs e)
        {
            using (SearchForm form = new SearchForm(presenter))
            {
                form.ShowDialog();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (SaveForm saveForm = new SaveForm(presenter))
            {
                saveForm.ShowDialog();
            }
        }

        private void containerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateViewedData();
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            using (DeleteForm dltForm = new DeleteForm(containerBox.SelectedItem.ToString(), presenter))
            {
                dltForm.ShowDialog();
            }

            presenter.UpdateData();
            UpdateViewedData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (AddForm addForm = new AddForm(containerBox.SelectedItem.ToString(), presenter))
            {
                addForm.ShowDialog();
            }

            presenter.UpdateData();
            UpdateViewedData();
        }

        public void UpdateViewedData()
        {
            ContainerViewer.DataSource = null;
            ContainerViewer.DataSource = presenter.GetContentFromName(containerBox.SelectedItem.ToString());
            
        }
    }
}
