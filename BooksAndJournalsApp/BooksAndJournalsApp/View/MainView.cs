﻿using BooksAndJournalsApp.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BooksAndJournalsApp
{
    public partial class MainView : Form
    {
        public PublishedEditionsPresenter presenter { get; set; }

        public MainView()
        {
            InitializeComponent();
        }

        private void authorsWorksBtn_Click(object sender, EventArgs e)
        {
            using (SearchView form = new SearchView(presenter))
            {
                form.ShowDialog();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (SaveView saveForm = new SaveView(presenter))
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
            using (DeleteView dltForm = new DeleteView(containerBox.SelectedItem.ToString(), presenter))
            {
                dltForm.ShowDialog();
            }

            UpdateViewedData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (AddView addForm = new AddView(containerBox.SelectedItem.ToString(), presenter))
            {
                addForm.ShowDialog();
            }

            UpdateViewedData();
        }

        public void UpdateViewedData()
        {
            ContainerViewer.DataSource = typeof(List<>);
            ContainerViewer.DataSource = presenter.GetContentFromName(containerBox.SelectedItem.ToString());
            
        }

        public void ShowError(string errorMessage)
        {
            if (errorMessage != string.Empty)
            {
                MessageBox.Show(errorMessage, "Exception", MessageBoxButtons.OK);
            }
        }

        public void Init()
        {
            if (presenter != null)
            {
                containerBox.DataSource = presenter.GetListDataSources();
            }
        }
    }
}
