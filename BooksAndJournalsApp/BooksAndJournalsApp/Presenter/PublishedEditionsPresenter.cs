using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BooksAndJournalsApp.Presenter
{
    public class PublishedEditionsPresenter
    {
        private PublishedEditionsModel _model;
        private MainView _view;

        public PublishedEditionsPresenter(PublishedEditionsModel model, MainView view)
        {
            _model = model;
            _view = view;

            _view.presenter = this;
        }

        public List<string> GetListDataSources()
        {
            return _model.dataSources;
        }

        public void OnSaveViewSaveBtnClick(string booksSaveOption, string journalsSaveOption, string newspapersSaveOption)
        {
            _view.ShowError(_model.Serialize(_model.books, booksSaveOption));
            _view.ShowError(_model.Serialize(_model.journals, journalsSaveOption));
            _view.ShowError(_model.Serialize(_model.newspapers, newspapersSaveOption));
        }

        public List<string> OnSearchViewSearchBtnClick(string author)
        {
            List<string> resultingJournalArticles = new List<string>();

            var bookResult = from book in _model.books where book.Author.Contains(author) || book.Author == author select book.Title;
            var journalResult = from journal in _model.journals where journal.Author.Contains(author) || journal.Author == author select journal;

            foreach (var journal in journalResult)
            {
                int journalIndex = _model.journals.IndexOf(journal);

                List<string> articles = _model.journals[journalIndex].Articles.Split(';').ToList();
                List<string> authors = _model.journals[journalIndex].Author.Split(';').ToList();

                int authorIndex = authors.IndexOf(author);
                resultingJournalArticles.Add(articles[authorIndex]);
            }

           return bookResult.Concat(resultingJournalArticles).ToList();
        }

        public HashSet<string> GetAllAuthors()
        {
            HashSet<string> authors = new HashSet<string>();

            for (int bookId = 0; bookId < _model.books.Count; bookId++)
            {
                if (!_model.books[bookId].Author.Contains(";"))
                {
                    authors.Add(_model.books[bookId].Author);
                }

                else
                {
                    List<string> tmpBookAuthors = _model.books[bookId].Author.Split(';').ToList();
                    for (int authorId = 0; authorId < tmpBookAuthors.Count; authorId++)
                    {
                        authors.Add(tmpBookAuthors[authorId]);
                    }
                }
            }

            for (int journal = 0; journal < _model.journals.Count; journal++)
            {
                List<string> tmpauthors = _model.journals[journal].Author.Split(';').ToList();
                for (int authorId = 0; authorId < tmpauthors.Count; authorId++)
                {
                    authors.Add(tmpauthors[authorId]);
                }
            }

            return authors;
        }

        public dynamic GetContentFromName(string contentType)
        {
            if (contentType == "Book")
            {
                return _model.books; 
            }

            if (contentType == "Journal")
            {
                return _model.journals;
            }

            if (contentType == "Newspaper")
            {
                return _model.newspapers;
            }

            return null;
        }

        public void OnDeleteViewsDltRowBtnClick(dynamic Row)
        {
            if (Row.ToString() == "Book")
            {
                _model.books.Remove((Book)Row);
            }

            if (Row.ToString() == "Journal")
            {
                _model.journals.Remove((Journal)Row);
            }

            if (Row.ToString() == "Newspaper")
            {
                _model.newspapers.Remove((Newspaper)Row);
            }
        }

        public void AddBook(string author, string title)
        {
            Book book = new Book();
            book.Author = author;
            book.Title = title;

            _model.books.Add(book);
        }

        public void AddJournal(string authors, string title, string articles)
        {
            Journal journal = new Journal();
            journal.Author = authors;
            journal.Title = title;
            journal.Articles = articles;

            _model.journals.Add(journal);
        }

        public void AddNewspaper(string publisher, string title)
        {
            Newspaper newspaper = new Newspaper();
            newspaper.Publisher = publisher;
            newspaper.Title = title;

            _model.newspapers.Add(newspaper);
        }

        public string GetUnicId()
        {
            return _model.UnicId++.ToString();
        }
    }
}
