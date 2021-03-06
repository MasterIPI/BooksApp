﻿using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using AdditionalDataProvider;
using Enums;
using Entities;
using System;
using System.Windows.Forms;

namespace Models
{
    public class NewspaperModel
    {
        public NewspaperModel()
        {
            UpdateNewspapers();
        }

        public void Serialize(string fileFormat, List<Newspaper> Newspapers)
        {
            string filePath = ContentType.Newspaper.ToString() + fileFormat;

            if (fileFormat == SaveOption.Xml)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(DataTable));

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, Newspapers);
                }
            }

            if (fileFormat == SaveOption.Text)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, Newspapers);
                }
            }
        }

        public List<Newspaper> UpdateNewspapers()
        {
            DataTable _newspapers = new DataTable();
            SqlDataAdapter adapternewspapers = new SqlDataAdapter("select [Newspapers].Id as Id, [Newspapers].Title as Newspaper, [Newspapers].Publisher as Publisher from [Newspapers];", DataSources.DbConnect);
            adapternewspapers.Fill(_newspapers);

            List<Newspaper> Newspapers = (from row in _newspapers.AsEnumerable() select (new Newspaper(Int32.Parse(row["Id"].ToString()), row["Newspaper"].ToString(), row["Publisher"].ToString()))).ToList();

            foreach (Newspaper newspaper in Newspapers)
            {
                DataTable articles = new DataTable();
                adapternewspapers = new SqlDataAdapter($"select [Newspapers_Articles].Title as Article from [Newspapers_Articles] inner join [Newspapers] on [Newspapers_Articles].NewspaperId = [Newspapers].Id where [Newspapers].Id = {newspaper.Id}", DataSources.DbConnect);
                adapternewspapers.Fill(articles);

                newspaper.Articles.AddRange((from row in articles.AsEnumerable() select (row["Article"].ToString())).ToList());
            }

            return Newspapers;
        }

        public void RemoveFromNewspapers(int Id)
        {
            using (SqlConnection connection = new SqlConnection(DataSources.DbConnect))
            {
                SqlCommand command = new SqlCommand("RemoveFromNewspapers", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", Id);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void AddNewspaper(string title, string publisher, string articleName)
        {
            using (SqlConnection connection = new SqlConnection(DataSources.DbConnect))
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
