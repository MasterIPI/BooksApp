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
}
