using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using AdditionalDataProvider;
using Enums;
using Entities;

namespace Models
{
    public class JournalModel
    {
        public List<Journal> Journals = new List<Journal>(); 

        public JournalModel()
        {
            UpdateJournals();
        }

        public void Serialize(string fileFormat)
        {
            string filePath = ContentType.Journal + fileFormat;

            if (fileFormat == SaveOption.Xml)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(DataTable));

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, Journals);
                }
            }

            if (fileFormat == SaveOption.Text)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, Journals);
                }
            }
        }

        public void UpdateJournals()
        {
            DataTable _journals = new DataTable();

            SqlDataAdapter adapterjournals = new SqlDataAdapter("select [Journals].Id as Id, [Journals].Title as Journal from [Journals];", DataSources.DbConnect);
            
            adapterjournals.Fill(_journals);

            Journals = (from row in _journals.AsEnumerable() select (new Journal(Int32.Parse(row["Id"].ToString()),row["Journal"].ToString()))).ToList();

            foreach(Journal journal in Journals)
            {
                DataTable articles = new DataTable();
                adapterjournals = new SqlDataAdapter($"select [Journal_Articles].Id as Id, [Journal_Articles].Title as Article from [Journal_Articles] inner join [Journals_to_JournalArticles] on [Journal_Articles].Id = [Journals_to_JournalArticles].ArticleId inner join [Journals] on [Journals_to_JournalArticles].JournalId = [Journals].Id where [Journals].Id = {journal.Id}", DataSources.DbConnect);
                adapterjournals.Fill(articles);

                journal.Articles.AddRange((from row in articles.AsEnumerable() select(new JournalArticle(Int32.Parse(row["Id"].ToString()), row["Article"].ToString()))).ToList());

                foreach(JournalArticle article in journal.Articles)
                {
                    DataTable authors = new DataTable();
                    adapterjournals = new SqlDataAdapter($"select [Authors].Id, [Authors].Name as Name, [Authors].YearOfBirth as YearOfBirth from [Authors] inner join [JournalArticles_to_Authors] on [Authors].Id = [JournalArticles_to_Authors].AuthorId where [JournalArticles_to_Authors].ArticleId = {article.Id};", DataSources.DbConnect);
                    adapterjournals.Fill(authors);

                    article.Authors.AddRange((from row in authors.AsEnumerable() select (new Author(Int32.Parse(row["Id"].ToString()), row["Name"].ToString(), Int32.Parse(row["YearOfBirth"].ToString())))).ToList());
                }
            }
        }

        public void RemoveFromJournals(string title)
        {
            using (SqlConnection connection = new SqlConnection(DataSources.DbConnect))
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
            using (SqlConnection connection = new SqlConnection(DataSources.DbConnect))
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
