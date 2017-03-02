using BooksAndJournalsApp.Presenter;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BooksAndJournalsApp
{
    public class PublishedEditionsModel
    {
        public List<Book> books = new List<Book>();
        public List<Journal> journals = new List<Journal>();
        public List<Newspaper> newspapers = new List<Newspaper>();
        public List<string> dataSources = new List<string>();

        public int UnicId = 1;

        private string dbConncect;

        public PublishedEditionsModel ()
        {
            Init();
        }

        private void Init()
        {
            Book book = new Book();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();
            Book book6 = new Book();
            Book book7 = new Book();

            book.Author = "J. K. Rowling";
            book.Title = "Harry Potter and the Philosopher's Stone";
            books.Add(book);

            book1.Author = "J. K. Rowling";
            book1.Title = "Harry Potter and the Chamber of Secrets";
            books.Add(book1);

            book2.Author = "J. K. Rowling";
            book2.Title = "Harry Potter and the Prisoner of Azkaban";
            books.Add(book2);

            book3.Author = "J. K. Rowling";
            book3.Title = "Harry Potter and the Goblet of Fire";
            books.Add(book3);

            book4.Author = "J. K. Rowling";
            book4.Title = "Harry Potter and the Order of the Phoenix";
            books.Add(book4);

            book5.Author = "J. K. Rowling";
            book5.Title = "Harry Potter and the Half-Blood Prince";
            books.Add(book5);

            book6.Author = "J. K. Rowling";
            book6.Title = "Harry Potter and the Deathly Hallows";
            books.Add(book6);

            book7.Author = "Test Author1;TestAuthor2";
            book7.Title = "Test Title";
            books.Add(book7);

            Journal journal = new Journal();
            Journal journal1 = new Journal();

            journal.Title = "Nature";
            journal.Author = "C. Davisson and L. H. Germer;J. Chadwick;L. Meitner and O. R. Frisch;J. D. Watson and F. H. C. Crick;J. C. Kendrew, G. Bodo, H. M. Dintzis, R. G. Parrish, H. Wyckoff, D. C. Phillips;J. Tuzo Wilson;A. Hewish, S. J. Bell, J. D. H. Pilkington, P. F. Scott & R. A. Collins;J. C. Farman, B. G. Gardiner and J. D. Shanklin;I. Wilmut, A. E. Schnieke, J. McWhir, A. J. Kind and K. H. S. Campbell;International Human Genome Sequencing Consortium";
            journal.Articles = "Wave nature of particles;The neutron;Nuclear fission;The structure of DNA;First molecular protein structure (myoglobin);Plate tectonics;Pulsars;The ozone hole;First cloning of a mammal;The human genome";
            journals.Add(journal);

            journal1.Title = "Proceedings of the Royal Society";
            journal1.Author = "Dirac, P. a. M.;Heisenberg, W.;Oliphant M. L. E., Kempton A. E., Rutherford Lord;Schrodinger, E.";
            journal1.Articles = "Quantised Singularities in the Electromagnetic Field;On the Theory of Statistical and Isotropic Turbulence;Some Nuclear Transformations of Beryllium and Boron, and the Masses of the Light Elements;The Wave Equation for Spin 1 in Hamiltonian Form. II";
            journals.Add(journal1);

            Newspaper news = new Newspaper();
            Newspaper news1 = new Newspaper();

            news.Title = "The New York Times";
            news.Publisher = "Arthur Ochs Sulzberger, Jr.";
            newspapers.Add(news);

            news1.Title = "The Wall Street Journal";
            news1.Publisher = "Dow Jones & Company";
            newspapers.Add(news1);

            dataSources.Add(books.First().ToString());
            dataSources.Add(journals.First().ToString());
            dataSources.Add(newspapers.First().ToString());

            dbConncect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iwinn\Source\Repos\BooksApp\BooksAndJournalsApp\BooksAndJournalsApp\PublishedEditions.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public string Serialize<T>(List<T> list, string fileFormat)
        {
            string filePath = string.Empty;

            if (list is List<Book>)
            {
                filePath = "Books" + fileFormat;

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
                        return ex.ToString();
                    }
                }
            }

            if (list is List<Journal>)
            {
                filePath = "Journals" + fileFormat;
            }

            if (list is List<Newspaper>)
            {
                filePath = "Newspapers" + fileFormat;
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

            return string.Empty;
        }
    }
}
