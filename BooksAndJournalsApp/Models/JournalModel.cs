using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Models
{
    public class JournalModel
    {
        public DataTable journals = new DataTable();
        private string _dbConnect;
        public JournalModel(string dbConnect)
        {
            _dbConnect = dbConnect;
            journals.TableName = "Journals";
        }

        public void Serialize(string fileFormat)
        {
            string filePath = journals.TableName + fileFormat;

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
            journals.Clear();
            SqlDataAdapter adapterjournals = new SqlDataAdapter("select journals.title as Journal, journal_articles.title as Article, authors.name as Author, authors.yearofbirth as YearOfBirth from journals inner join journal_articles on journals.id = journal_articles.journalid inner join authors on journal_articles.authorid = authors.id;", _dbConnect);
            adapterjournals.Fill(journals);
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
