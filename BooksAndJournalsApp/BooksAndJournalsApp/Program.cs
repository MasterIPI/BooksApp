using BooksAndJournalsApp.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksAndJournalsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PublishedEditionsModel model = new PublishedEditionsModel();
            MainView view = new MainView();
            PublishedEditionsPresenter presenter = new PublishedEditionsPresenter(model, view);
            view.Init();

            Application.Run(view);
        }
    }
}
