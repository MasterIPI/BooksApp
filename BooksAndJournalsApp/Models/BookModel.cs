using System.Collections.Generic;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using Entities;
using System;
using System.Linq;
using AdditionalDataProvider;
using Enums;
using System.Windows.Forms;

namespace Models
{
    public class BookModel
    {
        public BookModel()
        {
            UpdateBooks();
        }

        public void Serialize(string fileFormat, List<Book> Books)
        {
            string filePath = ContentType.Book.ToString() + fileFormat;

            if (fileFormat == SaveOption.Xml)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(DataTable));

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, Books);
                }
            }

            if (fileFormat == SaveOption.Text)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, Books);
                }
            }
        }
        
        public void AddBook(string title, string authorName, int yearOfBirth)
        {
            using (SqlConnection connection = new SqlConnection(DataSources.DbConnect))
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

        public void RemoveFromBooks(int Id)
        {
            using (SqlConnection connection = new SqlConnection(DataSources.DbConnect))
            {
                SqlCommand command = new SqlCommand("RemoveFromBooks", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", Id);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public List<Book> UpdateBooks()
        {
            DataTable _books = new DataTable();
            SqlDataAdapter adapterbooks = new SqlDataAdapter("select books.Id as Id, books.title as Book from books;", DataSources.DbConnect);
            adapterbooks.Fill(_books);

            List<Book> Books = (from row in _books.AsEnumerable() select (new Book(Int32.Parse(row["Id"].ToString()), row["Book"].ToString()))).ToList();

            foreach (Book book in Books)
            {
                DataTable authors = new DataTable();
                adapterbooks = new SqlDataAdapter($"select authors.Id as Id, authors.name as Author, authors.YearOfBirth as YearOfBirth from Books inner join book_to_authors on books.id = book_to_authors.bookid inner join authors on book_to_authors.authorid = authors.id where books.Title = '{book.Title.Replace("'","''")}';", DataSources.DbConnect);
                adapterbooks.Fill(authors);

                book.Authors.AddRange((from row in authors.AsEnumerable() select (new Author(Int32.Parse(row["Id"].ToString()), row["Author"].ToString(), Int32.Parse(row["YearOfBirth"].ToString())))).ToList());
            }

            return Books;
        }
    }
}
