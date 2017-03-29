using Enums;
using System.Collections.Generic;

namespace AdditionalDataProvider
{
    public static class SaveOption
    {
        public static string Text { get { return _textOption; } }
        public static string Xml { get { return _xmlOption; } }

        private static string _textOption = ".txt";
        private static string _xmlOption = ".xml";
        public static List<string> saveFileOptions = new List<string> { _textOption, _xmlOption };
    }

    public static class DataSources
    {
        private static string _dbConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iwinn\Source\Repos\BooksApp\BooksAndJournalsApp\BooksAndJournalsApp\PublishedEditions.mdf;Integrated Security=True";
        public static string DbConnect { get { return _dbConnect; } }
    }
}
