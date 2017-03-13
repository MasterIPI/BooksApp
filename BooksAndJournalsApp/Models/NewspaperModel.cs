using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Models
{
    public class NewspaperModel
    {
        public DataTable newspapers = new DataTable();
        private string _dbConnect;

        public NewspaperModel(string dbConnect)
        {
            _dbConnect = dbConnect;
            newspapers.TableName = "Newspapers";
        }

        public void Serialize(string fileFormat)
        {
            string filePath = newspapers.TableName + fileFormat;

            if (fileFormat == ".xml")
            {
                XmlSerializer formatter = new XmlSerializer(typeof(DataTable));

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, newspapers);
                }
            }

            if (fileFormat == ".txt")
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, newspapers);
                }
            }
        }

        public void UpdateNewspapers()
        {
            newspapers.Clear();
            SqlDataAdapter adapternewspapers = new SqlDataAdapter("select newspapers.title as Newspaper, newspapers.publisher as Publisher, Newspapers_Articles.Title as Article from newspapers inner join newspapers_articles on newspapers.id = Newspapers_Articles.newspaperid order by Newspaper;", _dbConnect);
            adapternewspapers.Fill(newspapers);
        }

        public void RemoveFromNewspapers(string title, string publisher)
        {
            using (SqlConnection connection = new SqlConnection(_dbConnect))
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

        public void AddNewspaper(string title, string publisher, string articleName)
        {
            using (SqlConnection connection = new SqlConnection(_dbConnect))
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
    }
}
