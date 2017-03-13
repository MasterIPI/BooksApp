using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Presenters;

namespace Forms
{
    public partial class SaveForm : Form
    {
        private PublishedEditionsPresenter _presenter;
        private List<string> saveFileOptions;

        public SaveForm(PublishedEditionsPresenter presenter)
        {
            _presenter = presenter;
            saveFileOptions = new List<string>();
            saveFileOptions.Add(".txt");
            saveFileOptions.Add(".xml");

            InitializeComponent();

            booksBox.Items.AddRange(saveFileOptions.ToArray());
            journalsBox.Items.AddRange(saveFileOptions.ToArray());
            newspapersBox.Items.AddRange(saveFileOptions.ToArray());
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _presenter.OnSaveViewSaveBtnClick(booksBox.SelectedItem.ToString(), journalsBox.SelectedItem.ToString(), newspapersBox.SelectedItem.ToString());
        }

        private void EnableSaveBtn(object sender, EventArgs e)
        {
            if (booksBox.Text != string.Empty && journalsBox.Text != string.Empty && newspapersBox.Text != string.Empty)
            {
                saveBtn.Enabled = true;
            }
        }
    }
}
