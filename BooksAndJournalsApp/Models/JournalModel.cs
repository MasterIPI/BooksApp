using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Models
{
    public class JournalModel
    {
        public List<Journal> journals = new List<Journal>(); 
        private string _dbConnect;

        public JournalModel(string dbConnect)
        {
            _dbConnect = dbConnect;
        }

        public void Serialize(string fileFormat)
        {
            string filePath = "Journals" + fileFormat;

            if (fileFormat == ".xml")
            {
                XmlSerializer formatter = new XmlSerializer(typeof(DataTable));

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, journals);
                }
            }

            if (fileFormat == ".txt")
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, journals);
                }
            }
        }

        public void UpdateJournals()
        {
            DataTable _journals = new DataTable();

            SqlDataAdapter adapterjournals = new SqlDataAdapter("select [Journals].Title as Journal from [Journals];", _dbConnect);
            
            adapterjournals.Fill(_journals);

            journals = (from row in _journals.AsEnumerable() select (new Journal(row["Journal"].ToString()))).ToList();

            foreach(Journal journal in journals)
            {
                DataTable articles = new DataTable();
                adapterjournals = new SqlDataAdapter($"select [Journal_Articles].Title as Article from [Journal_Articles] inner join [Journals_to_JournalArticles] on [Journal_Articles].Id = [Journals_to_JournalArticles].ArticleId inner join [Journals] on [Journals_to_JournalArticles].JournalId = [Journals].Id where [Journals].Title = '{journal.Title}'", _dbConnect);
                adapterjournals.Fill(articles);

                journal.Articles.AddRange((from row in articles.AsEnumerable() select(new JournalArticle(row["Article"].ToString()))).ToList());

                foreach(JournalArticle article in journal.Articles)
                {
                    DataTable authors = new DataTable();
                    adapterjournals = new SqlDataAdapter($"select [Authors].Name as Name, [Authors].YearOfBirth as YearOfBirth from [Authors] inner join [JournalArticles_to_Authors] on [Authors].Id = [JournalArticles_to_Authors].AuthorId where [JournalArticles_to_Authors].ArticleId = (select [Journal_Articles].Id from [Journal_Articles] where [Journal_Articles].Title = '{article.Article}');", _dbConnect);
                    adapterjournals.Fill(authors);

                    article.Authors.AddRange((from row in authors.AsEnumerable() select (new Author(row["Name"].ToString(), Int32.Parse(row["YearOfBirth"].ToString())))).ToList());
                }
            }
        }

        public void RemoveFromJournals(string title)
        {
            using (SqlConnection connection = new SqlConnection(_dbConnect))
            {
                SqlCommand command = new SqlCommand("RemoveFromJournals", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@journalTitle", title);
                connection.Open();

                command.ExecuteNonQuery();
            }

            UpdateJournals();
        }

        public void AddJournal(string title, string authorName, int yearOfBirth, string articleName)
        {
            using (SqlConnection connection = new SqlConnection(_dbConnect))
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
    }
}
