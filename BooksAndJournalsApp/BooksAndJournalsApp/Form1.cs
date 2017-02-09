using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksAndJournalsApp
{
    public partial class Form1 : Form
    {
        private List<PublishedEdition> list = new List<PublishedEdition>();
        public Form1()
        {
            for (int i = 0; i < 10; i++)
            {
                Book book = new Book();
                book.Author = "Author" + (i + 1).ToString();
                book.Title = "Book" + (i + 1).ToString();
                list.Add(book);
            }

            for (int i = 0; i < 10; i++)
            {
                Journal journal = new Journal();
                journal.Author = "Author" + (i + 1).ToString();
                journal.Title = "Journal" + (i + 1).ToString();
                list.Add(journal);
            }

            InitializeComponent();
            ListViewer.DataSource = list;
        }
    }
}
