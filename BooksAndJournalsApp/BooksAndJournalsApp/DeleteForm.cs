using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BooksAndJournalsApp.DataContainer;

namespace BooksAndJournalsApp
{
    public partial class DeleteForm : Form
    {
        public DeleteForm(string contentType)
        {
            InitializeComponent();

            if (contentType == "Book")
            {
                ContentViewer.DataSource = books;
            }

            if (contentType == "Journal")
            {
                ContentViewer.DataSource = journals;
            }

            if (contentType == "Newspaper")
            {
                ContentViewer.DataSource = newspapers;
            }
        }

        private void dltRowBtn_Click(object sender, EventArgs e)
        {
            var item = ContentViewer.CurrentRow.DataBoundItem;
            ContentViewer.DataSource = null;

            if (item.ToString() == "Book")
            {
                books.Remove((Book)item);
                ContentViewer.DataSource = books;
            }

            if (item.ToString() == "Journal")
            {
                journals.Remove((Journal)item);
                ContentViewer.DataSource = journals;
            }

            if (item.ToString() == "Newspaper")
            {
                newspapers.Remove((Newspaper)item);
                ContentViewer.DataSource = newspapers;
            }
        }
    }
}
