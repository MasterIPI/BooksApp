﻿using BooksAndJournalsApp.Presenter;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using BooksAndJournalsApp.View;

namespace BooksAndJournalsApp
{
    public partial class AddView : Form
    {
        private PublishedEditionsPresenter _presenter;

        private int textBoxHeight = 35;
        private int textBoxWidth = 100;
        private Point startPoint = new Point(15, 15);

        public AddView(string contentType, PublishedEditionsPresenter presenter)
        {
            _presenter = presenter;

            InitializeComponent();

            if (contentType == "Book")
            {
                Label authorlbl = new Label();
                authorlbl.Location = startPoint;
                authorlbl.AutoSize = true;
                authorlbl.Text = "Author";
                Controls.Add(authorlbl);

                TextBox authorBox = new TextBox();
                authorBox.Location = new Point(authorlbl.Location.X + authorlbl.Width, authorlbl.Location.Y);
                authorBox.Size = new Size(textBoxWidth, textBoxHeight);
                authorBox.Name = "AuthorBox";
                Controls.Add(authorBox);

                Label authorlbl2 = new Label();
                authorlbl2.Location = new Point(authorBox.Location.X + authorBox.Width, authorBox.Location.Y);
                authorlbl2.AutoSize = true;
                authorlbl2.Text = "Add book with only 1 author";
                Controls.Add(authorlbl2);

                Label titlelbl = new Label();
                titlelbl.Location = new Point(startPoint.X, startPoint.Y + textBoxHeight);
                titlelbl.AutoSize = true;
                titlelbl.Text = "Title";
                Controls.Add(titlelbl);

                TextBox titleBox = new TextBox();
                titleBox.Location = new Point(titlelbl.Location.X + titlelbl.Width, titlelbl.Location.Y);
                titleBox.Size = new Size(textBoxWidth, textBoxHeight);
                titleBox.Name = "TitleBox";
                Controls.Add(titleBox);

                Button addBtn = new Button();
                addBtn.Text = "Add";
                addBtn.AutoSize = true;
                addBtn.Location = new Point(titleBox.Location.X + (titleBox.Width - addBtn.Width), titleBox.Location.Y + textBoxHeight);
                addBtn.Click += AddBook;
                Controls.Add(addBtn);
            }

            if (contentType == "Journal")
            {
                Label authorlbl = new Label();
                authorlbl.Location = startPoint;
                authorlbl.AutoSize = true;
                authorlbl.Text = "Author";
                Controls.Add(authorlbl);

                TextBox authorBox = new TextBox();
                authorBox.Location = new Point(authorlbl.Location.X + authorlbl.Width, authorlbl.Location.Y);
                authorBox.Size = new Size(textBoxWidth, textBoxHeight);
                authorBox.Name = "AuthorBox";
                Controls.Add(authorBox);

                Label authorlbl2 = new Label();
                authorlbl2.Location = new Point(authorBox.Location.X + authorBox.Width, authorBox.Location.Y);
                authorlbl2.AutoSize = true;
                authorlbl2.Text = "If you want to add more than 1 author, please use the \";\" symbol!!!";
                Controls.Add(authorlbl2);

                Label titlelbl = new Label();
                titlelbl.Location = new Point(startPoint.X, startPoint.Y + textBoxHeight);
                titlelbl.AutoSize = true;
                titlelbl.Text = "Title";
                Controls.Add(titlelbl);

                TextBox titleBox = new TextBox();
                titleBox.Location = new Point(titlelbl.Location.X + titlelbl.Width, titlelbl.Location.Y);
                titleBox.Size = new Size(textBoxWidth, textBoxHeight);
                titleBox.Name = "TitleBox";
                Controls.Add(titleBox);

                Label articlelbl = new Label();
                articlelbl.Location = new Point(startPoint.X, titlelbl.Location.Y + textBoxHeight);
                articlelbl.AutoSize = true;
                articlelbl.Text = "Articles";
                Controls.Add(articlelbl);

                TextBox articleBox = new TextBox();
                articleBox.Location = new Point(articlelbl.Location.X + articlelbl.Width, articlelbl.Location.Y);
                articleBox.Size = new Size(textBoxWidth, textBoxHeight);
                articleBox.Name = "ArticleBox";
                Controls.Add(articleBox);

                Label articlelbl2 = new Label();
                articlelbl2.Location = new Point(articleBox.Location.X + articleBox.Width, articleBox.Location.Y);
                articlelbl2.AutoSize = true;
                articlelbl2.Text = "If you want to add more than 1 article, please use the \";\" symbol!!!";
                Controls.Add(articlelbl2);

                Button addBtn = new Button();
                addBtn.Text = "Add";
                addBtn.AutoSize = true;
                addBtn.Location = new Point(articleBox.Location.X + (articleBox.Width - addBtn.Width), articleBox.Location.Y + textBoxHeight);
                addBtn.Click += AddJournal;
                Controls.Add(addBtn);
            }

            if (contentType == "Newspaper")
            {
                Label publisherlbl = new Label();
                publisherlbl.Location = startPoint;
                publisherlbl.AutoSize = true;
                publisherlbl.Text = "Publisher";
                Controls.Add(publisherlbl);

                TextBox publisherBox = new TextBox();
                publisherBox.Location = new Point(publisherlbl.Location.X + publisherlbl.Size.Width, publisherlbl.Location.Y);
                publisherBox.Size = new Size(textBoxWidth, textBoxHeight);
                publisherBox.Name = "PublisherBox";
                Controls.Add(publisherBox);

                Label titlelbl = new Label();
                titlelbl.Location = new Point(startPoint.X, startPoint.Y + textBoxHeight);
                titlelbl.AutoSize = true;
                titlelbl.Text = "Title";
                Controls.Add(titlelbl);

                TextBox titleBox = new TextBox();
                titleBox.Location = new Point(titlelbl.Location.X + titlelbl.Width, titlelbl.Location.Y);
                titleBox.Size = new Size(textBoxWidth, textBoxHeight);
                titleBox.Name = "TitleBox";
                Controls.Add(titleBox);

                Button addBtn = new Button();
                addBtn.Text = "Add";
                addBtn.AutoSize = true;
                addBtn.Location = new Point(titleBox.Location.X + (titleBox.Width - addBtn.Width), titleBox.Location.Y + textBoxHeight);
                addBtn.Click += AddNewspaper;
                Controls.Add(addBtn);
            }
        }

        private void AddBook(object sender, EventArgs e)
        {
            if (Controls["AuthorBox"].Text == string.Empty || Controls["TitleBox"].Text == string.Empty)
            {
                MessageBox.Show("All of the fields must be not empty!", "Warning!!!");
            }

            else
            {
                _presenter.AddBook(CheckAuthors(Controls["AuthorBox"].Text), Controls["TitleBox"].Text);

                Controls["AuthorBox"].Text = string.Empty;
                Controls["TitleBox"].Text = string.Empty;
            }
        }

        private void AddJournal(object sender, EventArgs e)
        {
            if (Controls["AuthorBox"].Text == string.Empty || Controls["TitleBox"].Text == string.Empty || Controls["ArticleBox"].Text == string.Empty)
            {
                MessageBox.Show("All of the fields must be not empty!", "Warning!!!");
            }

            else
            {
                _presenter.AddJournal(CheckAuthors(Controls["AuthorBox"].Text), Controls["TitleBox"].Text, Controls["ArticleBox"].Text);

                Controls["AuthorBox"].Text = string.Empty;
                Controls["ArticleBox"].Text = string.Empty;
                Controls["TitleBox"].Text = string.Empty;
            }
        }

        private void AddNewspaper(object sender, EventArgs e)
        {
            if (Controls["PublisherBox"].Text == string.Empty || Controls["TitleBox"].Text == string.Empty)
            {
                MessageBox.Show("All of the fields must be not empty!", "Warning!!!");
            }

            else
            {
                _presenter.AddNewspaper(Controls["PublisherBox"].Text, Controls["TitleBox"].Text);

                Controls["PublisherBox"].Text = string.Empty;
                Controls["TitleBox"].Text = string.Empty;
            }
        }

        private string CheckAuthors(string author)
        {
            HashSet<string> authors = new HashSet<string>();
            authors = _presenter.GetAllAuthors();

            List<string> matchedauthors = new List<string>();

            foreach (string item in authors)
            {
                if (item == author || item.Contains(author))
                {
                    matchedauthors.Add(item);
                }
            }

            if (matchedauthors.Count > 0)
            {
                using (CheckAuthorsView view = new CheckAuthorsView(matchedauthors))
                {
                    view.ShowDialog();
                    if (view.ActiveControl.Text == "No")
                    {
                        author = string.Empty;
                        author = view.Controls["MatchedBox"].Text + _presenter.GetUnicId();
                    }
                }
            }

            return author;
        }
    }
}
