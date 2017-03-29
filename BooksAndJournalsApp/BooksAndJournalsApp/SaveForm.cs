using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Presenters;
using AdditionalDataProvider;
using Views;

namespace Forms
{
    public partial class SaveForm : Form, ISaveView
    {
        private SavePresenter _presenter;

        public SaveForm()
        {
            _presenter = new SavePresenter(this);

            InitializeComponent();

            DrpBoxBooks.Items.AddRange(SaveOption.saveFileOptions.ToArray());
            DrpBoxJournals.Items.AddRange(SaveOption.saveFileOptions.ToArray());
            DrpBoxNewspapers.Items.AddRange(SaveOption.saveFileOptions.ToArray());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _presenter.OnSaveViewSaveBtnClick(DrpBoxBooks.SelectedItem.ToString(), DrpBoxJournals.SelectedItem.ToString(), DrpBoxNewspapers.SelectedItem.ToString());
        }

        private void EnableBtnSave(object sender, EventArgs e)
        {
            if (DrpBoxBooks.Text != string.Empty && DrpBoxJournals.Text != string.Empty && DrpBoxNewspapers.Text != string.Empty)
            {
                BtnSave.Enabled = true;
            }
        }
    }
}
