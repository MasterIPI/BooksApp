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
    public partial class SearchForm : Form
    {
        private List<string> results = new List<string>();
        private HashSet<string> authors = new HashSet<string>();

        public SearchForm()
        {
            InitializeComponent();

            foreach (Book book in books)
            {
                authors.Add(book.Author);
            }

            for (int journal = 0; journal < journals.Count; journal++)
            {
                List<string> tmpauthors = journals[journal].Author.Split(';').ToList();
                for (int author = 0; author < tmpauthors.Count; author++)
                {
                    authors.Add(tmpauthors[author]);
                }
            }

            AuthorsBox.DataSource = authors.ToList();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<string> resultingJournalArticles = new List<string>();

            var bookResult = from book in books where book.Author == AuthorsBox.SelectedItem.ToString() select book.Title;
            var journalResult = from journal in journals where journal.Author.Contains(AuthorsBox.SelectedItem.ToString()) || journal.Author == AuthorsBox.SelectedItem.ToString() select journal;

            foreach (var journal in journalResult)
            {
                int journalIndex = journals.IndexOf(journal);

                List<string> articles = journals[journalIndex].Articles.Split(';').ToList();
                List<string> authors = journals[journalIndex].Author.Split(';').ToList();

                int authorIndex = authors.IndexOf(AuthorsBox.SelectedItem.ToString());
                resultingJournalArticles.Add(articles[authorIndex]);
            }

            searchResultsView.DataSource = bookResult.Concat(resultingJournalArticles).ToList();
        }

        private void AuthorsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBtn.Enabled = true;
        }
    }
}
