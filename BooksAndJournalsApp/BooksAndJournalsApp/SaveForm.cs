using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data.SqlClient;
using static BooksAndJournalsApp.DataContainer;

namespace BooksAndJournalsApp
{
    public partial class SaveForm : Form
    {
        private List<string> saveFileOptions;
        private string dbConncect;
        public SaveForm()
        {
            saveFileOptions = new List<string>();
            saveFileOptions.Add(".txt");
            saveFileOptions.Add(".xml");

            dbConncect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iwinn\Source\Repos\BooksApp\BooksAndJournalsApp\BooksAndJournalsApp\PublishedEditions.mdf;Integrated Security=True;Connect Timeout=30";

            InitializeComponent();

            saveBtn.Enabled = false;
            booksBox.Items.AddRange(saveFileOptions.ToArray());
            booksBox.Items.Add(".db");
            journalsBox.Items.AddRange(saveFileOptions.ToArray());
            newspapersBox.Items.AddRange(saveFileOptions.ToArray());
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Serialize(books, booksBox.SelectedItem.ToString());
            Serialize(journals, journalsBox.SelectedItem.ToString());
            Serialize(newspapers, newspapersBox.SelectedItem.ToString());
        }

        private void Serialize<T>(List<T> list, string fileFormat)
        {
            string filePath = string.Empty;

            if (list is List<Book>)
            {
                filePath = bookslbl.Text + fileFormat;

                if (fileFormat == ".db")
                {
                    SqlConnection connection = new SqlConnection(dbConncect);
                    try
                    {
                        List<string> data = new List<string>();
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        
                        SqlCommand retrieveData = new SqlCommand("select * from Books");
                        retrieveData.Connection = connection;
                        SqlDataReader reader = retrieveData.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                data.Add(reader.GetValue(0).ToString() + reader.GetValue(1).ToString());
                            }
                        }

                        reader.Close();

                        foreach (var book in list)
                        {
                            if (data.Count > 0)
                            {
                                if (!data.Contains((book as Book).Author + (book as Book).Title))
                                {
                                    command.CommandText = string.Format($"INSERT INTO Books (Author, Title) VALUES ('{(book as Book).Author}','{(book as Book).Title.Replace("'", "''")}')");
                                    command.Connection = connection;
                                    command.ExecuteNonQuery();
                                }
                            }

                            else
                            {
                                command.CommandText = string.Format($"INSERT INTO Books (Author, Title) VALUES ('{(book as Book).Author}','{(book as Book).Title.Replace("'", "''")}')");
                                command.Connection = connection;
                                command.ExecuteNonQuery();
                            }
                        }

                        connection.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString(), "Conncection Problem");
                    }
                }
            }

            if (list is List<Journal>)
            {
                filePath = journalslbl.Text + fileFormat;
            }

            if (list is List<Newspaper>)
            {
                filePath = newspaperslbl.Text + fileFormat;
            }

            if (fileFormat == ".xml")
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<T>));

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, list);
                }
            }

            if (fileFormat == ".txt")
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, list);
                }
            }
        }

        private void EnableSaveBtn(object sender, EventArgs e)
        {
            if (booksBox.Text != string.Empty && journalsBox.Text != string.Empty && newspapersBox.Text != string.Empty)
            {
                saveBtn.Enabled = true;
            }
        }
    }
}
