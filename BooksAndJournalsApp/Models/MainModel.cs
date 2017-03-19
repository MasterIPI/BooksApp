using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MainModel
    {
        public BookModel _bookModel;
        public JournalModel _journalModel;
        public NewspaperModel _newspaperModel;

        public List<string> dataSources = new List<string>();

        private string dbConnect;

        public MainModel()
        {
            dataSources.Add("Book");
            dataSources.Add("Journal");
            dataSources.Add("Newspaper");

            dbConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iwinn\Source\Repos\BooksApp\BooksAndJournalsApp\BooksAndJournalsApp\PublishedEditions.mdf;Integrated Security=True";

            _bookModel = new BookModel(dbConnect);
            _journalModel = new JournalModel(dbConnect);
            _newspaperModel = new NewspaperModel(dbConnect);

            UpdateData();
        }

        public void UpdateData()
        {
            _bookModel.UpdateBooks();
            _journalModel.UpdateJournals();
            _newspaperModel.UpdateNewspapers();
        }

        public List<Author> GetAllAuthors()
        {
            DataTable authors = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select authors.Name as Name, authors.YearOfBirth as YearOfBirth from authors", dbConnect);

            adapter.Fill(authors);

            return (from row in authors.AsEnumerable() select (new Author(row["Name"].ToString(), Int32.Parse(row["YearOfBirth"].ToString())))).ToList();
        }

        public List<string> FindAuthorsWorks(string author, int yearofbirth)
        {
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter($"select books.title as Title from books inner join Book_to_Authors on books.Id = Book_to_Authors.BookId inner join authors on Book_to_Authors.AuthorId = authors.Id where authors.name = '{author}' and authors.yearofbirth = {yearofbirth} union (select journal_articles.title as Title from journal_articles inner join journalArticles_to_authors on journal_articles.Id = journalArticles_to_authors.ArticleId inner join Authors on journalArticles_to_authors.AuthorId = Authors.Id where authors.name = '{author}' and authors.yearofbirth = {yearofbirth});", dbConnect);

            adapter.Fill(result);

            return (from row in result.AsEnumerable() select (row["Title"].ToString())).ToList();
        }
    }
}
