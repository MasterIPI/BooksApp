using Entities;
using Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views;

namespace Forms
{
    public partial class DeleteJournalForm : Form, IDeleJournalView
    {
        private List<Journal> _journals = new List<Journal>();
        private DataGridViewRow _currentRow;
        private DeleteJournalPresenter _presenter;

        public DataGridViewRow CurrentRow
        {
            get
            {
                return _currentRow;
            }

            set
            {
                _currentRow = value;
            }
        }

        public List<Journal> Journals
        {
            get
            {
                return _journals;
            }

            set
            {
                _journals = value;
            }
        }

        public DeleteJournalForm(ref List<Journal> journals)
        {
            _presenter = new DeleteJournalPresenter(this);
            _journals = journals;

            InitializeComponent();

            UpdateView();
        }

        private void BtnDeleteRow_Click(object sender, EventArgs e)
        {
            if (DGVContentViewer.CurrentRow.DataBoundItem != null)
            {
                CurrentRow = DGVContentViewer.CurrentRow;
                _presenter.DeleteRowBtnClick();
                UpdateView();
            }
        }

        public void UpdateView()
        {
            DGVContentViewer.DataSource = null;
            DGVContentViewer.DataSource = Journals;
            DGVContentViewer.Columns["Id"].Visible = false;
        }
    }
}
