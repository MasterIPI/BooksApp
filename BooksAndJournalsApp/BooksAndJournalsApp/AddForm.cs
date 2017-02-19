using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BooksAndJournalsApp.DataContainer;

namespace BooksAndJournalsApp
{
    public partial class AddForm : Form
    {
        private int textBoxHeight = 35;
        private int textBoxWidth = 100;
        private Point startPoint = new Point(15, 15);

        public AddForm(string contentType)
        {
            InitializeComponent();

            if (contentType == "Book")
            {
                Label authorlbl = new Label();
                authorlbl.Location = startPoint;
                authorlbl.AutoSize = true;
                authorlbl.Text = "Author";
                Controls.Add(authorlbl);

                TextBox authorBox = new TextBox();
                authorBox.Location = new Point(authorlbl.Location.X + authorlbl.Size.Width, authorlbl.Location.Y);
                authorBox.Size = new Size(textBoxWidth, textBoxHeight);
                authorBox.Name = "AuthorBox";
                Controls.Add(authorBox);

                Label titlelbl = new Label();
                titlelbl.Location = new Point(startPoint.X, startPoint.Y + textBoxHeight);
                titlelbl.AutoSize = true;
                titlelbl.Text = "Title";
                Controls.Add(titlelbl);

                TextBox titleBox = new TextBox();
                titleBox.Location = new Point(authorBox.Location.X, titlelbl.Location.Y);
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
                authorBox.Location = new Point(authorlbl.Location.X + authorlbl.Size.Width, authorlbl.Location.Y);
                authorBox.Size = new Size(textBoxWidth, textBoxHeight);
                authorBox.Name = "AuthorBox";
                Controls.Add(authorBox);

                Label titlelbl = new Label();
                titlelbl.Location = new Point(startPoint.X, startPoint.Y + textBoxHeight);
                titlelbl.AutoSize = true;
                titlelbl.Text = "Title";
                Controls.Add(titlelbl);

                TextBox titleBox = new TextBox();
                titleBox.Location = new Point(authorBox.Location.X, titlelbl.Location.Y);
                titleBox.Size = new Size(textBoxWidth, textBoxHeight);
                titleBox.Name = "TitleBox";
                Controls.Add(titleBox);

                Label articlelbl = new Label();
                articlelbl.Location = new Point(startPoint.X, titlelbl.Location.Y + textBoxHeight);
                articlelbl.AutoSize = true;
                articlelbl.Text = "Articles";
                Controls.Add(articlelbl);

                TextBox articleBox = new TextBox();
                articleBox.Location = new Point(titleBox.Location.X, articlelbl.Location.Y);
                articleBox.Size = new Size(textBoxWidth, textBoxHeight);
                articleBox.Name = "ArticleBox";
                Controls.Add(articleBox);

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
                titleBox.Location = new Point(publisherBox.Location.X, titlelbl.Location.Y);
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
                Book book = new Book();
                book.Author = Controls["AuthorBox"].Text;
                book.Title = Controls["TitleBox"].Text;

                books.Add(book);

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
                Journal journal = new Journal();
                journal.Author = Controls["AuthorBox"].Text;
                journal.Articles = Controls["ArticleBox"].Text;
                journal.Title = Controls["TitleBox"].Text;

                journals.Add(journal);

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
                Newspaper newspaper = new Newspaper();
                newspaper.Publisher = Controls["PublisherBox"].Text;
                newspaper.Title = Controls["TitleBox"].Text;

                newspapers.Add(newspaper);

                Controls["PublisherBox"].Text = string.Empty;
                Controls["TitleBox"].Text = string.Empty;
            }
        }
    }
}
