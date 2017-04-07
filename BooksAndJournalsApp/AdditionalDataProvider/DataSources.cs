using System;

namespace AdditionalDataProvider
{
    public class DataSources
    {
        private static string _dbConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+AppDomain.CurrentDomain.BaseDirectory+"PublishedEditions.mdf;Integrated Security=True";
        public static string DbConnect { get { return _dbConnect; } }
    }
}
