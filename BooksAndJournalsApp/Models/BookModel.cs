﻿using System.Collections.Generic;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using Entities;
using System;
using System.Linq;

namespace Models
{
    public class BookModel
    {
        public List<Book> books = new List<Book>();
        private string _dbConnect;

        public BookModel (string dbConnect)
        {
            _dbConnect = dbConnect;
        }

        public void Serialize(string fileFormat)
        {
            string filePath = "Books" + fileFormat;

            if (fileFormat == ".xml")
            {
                XmlSerializer formatter = new XmlSerializer(typeof(DataTable));

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, books);
                }
            }

            if (fileFormat == ".txt")
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, books);
                }
            }
        }
        
        public void AddBook(string title, string authorName, int yearOfBirth)
        {
            using (SqlConnection connection = new SqlConnection(_dbConnect))
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

        public void RemoveFromBooks(string title)
        {
            using (SqlConnection connection = new SqlConnection(_dbConnect))
            {
                SqlCommand command = new SqlCommand("RemoveFromBooks", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@bookTitle", title);
                connection.Open();

                command.ExecuteNonQuery();
            }

            UpdateBooks();
        }

        public void UpdateBooks()
        {
            DataTable _books = new DataTable();
            SqlDataAdapter adapterbooks = new SqlDataAdapter("select books.title as Book, authors.name as Author, authors.yearofbirth as YearOfBirth, authors.Id as Id from books inner join authors on books.authorid = authors.id;", _dbConnect);
            adapterbooks.Fill(_books);

            books = (from row in _books.AsEnumerable() select (new Book(row["Book"].ToString(), new Author(Int32.Parse(row["Id"].ToString()), row["Author"].ToString(), Int32.Parse(row["YearOfBirth"].ToString()))))).ToList();
        }
    }
}