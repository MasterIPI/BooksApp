using Views;
using System.Collections.Generic;
using Entities;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using AdditionalDataProvider;
using System;

namespace Presenters
{
    public class SearchPresenter
    {
        private ISearchView _view;

        public SearchPresenter(ISearchView View)
        {
            _view = View;
        }

        public List<string> FindAuthorsWorks()
        {
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter($"select books.title as Title from books inner join Book_to_Authors on books.Id = Book_to_Authors.BookId inner join authors on Book_to_Authors.AuthorId = authors.Id where authors.Id = {_view.AuthorId} union (select journal_articles.title as Title from journal_articles inner join journalArticles_to_authors on journal_articles.Id = journalArticles_to_authors.ArticleId inner join Authors on journalArticles_to_authors.AuthorId = Authors.Id where authors.Id = {_view.AuthorId});", DataSources.DbConnect);

            adapter.Fill(result);

            return (from row in result.AsEnumerable() select (row["Title"].ToString())).ToList();
        }

        public List<Author> GetAllAuthors()
        {
            DataTable authors = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select authors.Id as Id, authors.Name as Name, authors.YearOfBirth as YearOfBirth from authors", DataSources.DbConnect);

            adapter.Fill(authors);

            return (from row in authors.AsEnumerable() select (new Author(Int32.Parse(row["Id"].ToString()), row["Name"].ToString(), Int32.Parse(row["YearOfBirth"].ToString())))).ToList();
        }
    }
}
