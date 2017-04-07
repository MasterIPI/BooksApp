using Entities;
using Enums;
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
    public partial class DeleteNewspaperForm : Form, IDeleteNewspaperView
    {
        private List<Newspaper> _newspapers = new List<Newspaper>();
        private DataGridViewRow _currentRow;
        private DeleteNewspaperPresenter _presenter;

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

        public List<Newspaper> Newspapers
        {
            get
            {
                return _newspapers;
            }

            set
            {
                _newspapers = value;
            }
        }

        public DeleteNewspaperForm(ref List<Newspaper> newspapers)
        {
            _presenter = new DeleteNewspaperPresenter(this);
            _newspapers = newspapers;

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
            DGVContentViewer.DataSource = Newspapers;
            DGVContentViewer.Columns["Id"].Visible = false;
        }
    }
}
