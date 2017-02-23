using System;
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
