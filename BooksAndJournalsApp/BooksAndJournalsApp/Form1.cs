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

            for (int journal = 0; journal < 10; journal++)
            {
                Journal tmpjournal = new Journal();

                for (int author = 0; author < 3; author++)
                {
                    tmpjournal.Author += "Author" + (author + 1).ToString() + "; ";
                    tmpjournal.Title += "Article" + (author + 1).ToString() + "; ";
                }
                
                list.Add(tmpjournal);
            }

            InitializeComponent();
            ListViewer.DataSource = list;
        }
    }
}
