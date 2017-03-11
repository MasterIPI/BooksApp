using System.Collections.Generic;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Models
{
    public class PublishedEditionsModel
    {
        public DataTable books = new DataTable();
        public DataTable journals = new DataTable();
        public DataTable newspapers = new DataTable();

        public List<string> dataSources = new List<string>();

        private string dbConncect;

        public PublishedEditionsModel ()
        {
            Init();
        }

        private void Init()
        {
            dataSources.Add("Book");
            dataSources.Add("Journal");
            dataSources.Add("Newspaper");

            books.TableName = "Books";
            journals.TableName = "Journals";
            newspapers.TableName = "Newspapers";

            dbConncect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iwinn\Source\Repos\BooksApp\BooksAndJournalsApp\BooksAndJournalsApp\PublishedEditions.mdf;Integrated Security=True";

            UpdateData();
        }

        public string Serialize(DataTable table, string fileFormat)
        {
            string filePath = string.Empty;

            if (table.TableName == "Books")
            {
                filePath = table.TableName + fileFormat;
            }

            if (table.TableName == "Journals")
            {
                filePath = table.TableName + fileFormat;
            }

            if (table.TableName == "Newspapers")
            {
                filePath = table.TableName + fileFormat;
            }

            if (fileFormat == ".xml")
            {
                XmlSerializer formatter = new XmlSerializer(typeof(DataTable));

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, table);
                }
            }

            if (fileFormat == ".txt")
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, table);
                }
            }

            return string.Empty;
        }

        public DataTable GetAllAuthors()
        {
            DataTable authors = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select authors.Name as Name, authors.YearOfBirth as YearOfBirth from authors", dbConncect);

            adapter.Fill(authors);

            return authors;
        }

        public DataTable FindAuthorsWorks(string author, int yearofbirth)
        {
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter($"select books.title as Title from books inner join authors on books.authorid = authors.id where authors.name = '{author}' and authors.yearofbirth = {yearofbirth} union (select journal_articles.title as Title from journal_articles inner join authors on journal_articles.authorid = authors.id where authors.name = '{author}' and authors.yearofbirth = {yearofbirth});", dbConncect);

            adapter.Fill(result);

            return result;
        }

        public void AddBook(string title, string authorName, int yearOfBirth)
        {
            using (SqlConnection connection = new SqlConnection(dbConncect))
            {
                SqlCommand command = new SqlCommand("InsertBook", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@bookTitle",title);
                command.Parameters.AddWithValue("@authorName", authorName);
                command.Parameters.AddWithValue("@yearofbirth", yearOfBirth);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void AddJournal(string title, string authorName, int yearOfBirth, string articleName)
        {
            using (SqlConnection connection = new SqlConnection(dbConncect))
            {
                SqlCommand command = new SqlCommand("InsertJournal", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@journalTitle", title);
                command.Parameters.AddWithValue("@authorName", authorName);
                command.Parameters.AddWithValue("@yearofbirth", yearOfBirth);
                command.Parameters.AddWithValue("@articleName", articleName);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void AddNewspaper(string title, string publisher, string articleName)
        {
            using (SqlConnection connection = new SqlConnection(dbConncect))
            {
                SqlCommand command = new SqlCommand("InsertNewspaper", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@newspaperTitle", title);
                command.Parameters.AddWithValue("@publisher", publisher);
                command.Parameters.AddWithValue("@articleName", articleName);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void RemoveFromBooks(string title)
        {
            using (SqlConnection connection = new SqlConnection(dbConncect))
            {
                SqlCommand command = new SqlCommand("RemoveFromBooks", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@bookTitle", title);
                connection.Open();

                command.ExecuteNonQuery();
            }

            UpdateBooks();
        }

        public void RemoveFromJournals(string title)
        {
            using (SqlConnection connection = new SqlConnection(dbConncect))
            {
                SqlCommand command = new SqlCommand("RemoveFromJournals", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@journalTitle", title);
                connection.Open();

                command.ExecuteNonQuery();
            }

            UpdateJournals();
        }

        public void RemoveFromNewspapers(string title, string publisher)
        {
            using (SqlConnection connection = new SqlConnection(dbConncect))
            {
                SqlCommand command = new SqlCommand("RemoveFromNewspapers", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@newspaperTitle", title);
                command.Parameters.AddWithValue("@publisher", publisher);
                connection.Open();

                command.ExecuteNonQuery();
            }

            UpdateNewspapers();
        }

        public void UpdateData()
        {
            UpdateBooks();
            UpdateJournals();
            UpdateNewspapers();
        }

        private void UpdateBooks()
        {
            books.Clear();
            SqlDataAdapter adapterbooks = new SqlDataAdapter("select books.title as Book, authors.name as Author, authors.yearofbirth as YearOfBirth from books inner join authors on books.authorid = authors.id;", dbConncect);
            adapterbooks.Fill(books);
        }

        private void UpdateJournals()
        {
            journals.Clear();
            SqlDataAdapter adapterjournals = new SqlDataAdapter("select journals.title as Journal, journal_articles.title as Article, authors.name as Author, authors.yearofbirth as YearOfBirth from journals inner join journal_articles on journals.id = journal_articles.journalid inner join authors on journal_articles.authorid = authors.id;", dbConncect);
            adapterjournals.Fill(journals);
        }

        private void UpdateNewspapers()
        {
            newspapers.Clear();
            SqlDataAdapter adapternewspapers = new SqlDataAdapter("select newspapers.title as Newspaper, newspapers.publisher as Publisher, Newspapers_Articles.Title as Article from newspapers inner join newspapers_articles on newspapers.id = Newspapers_Articles.newspaperid order by Newspaper;", dbConncect);
            adapternewspapers.Fill(newspapers);
        }
    }
}
