using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using static BooksAndJournalsApp.DataContainer;

namespace BooksAndJournalsApp
{
    public partial class SaveForm : Form
    {
        private List<string> saveFileOptions;
        public SaveForm()
        {
            saveFileOptions = new List<string>();
            saveFileOptions.Add(".txt");
            saveFileOptions.Add(".xml");

            InitializeComponent();

            saveBtn.Enabled = false;
            booksBox.Items.AddRange(saveFileOptions.ToArray());
            journalsBox.Items.AddRange(saveFileOptions.ToArray());
            newspapersBox.Items.AddRange(saveFileOptions.ToArray());
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Serialize(books, booksBox.SelectedItem.ToString());
            Serialize(journals, journalsBox.SelectedItem.ToString());
            Serialize(newspapers, newspapersBox.SelectedItem.ToString());
        }

        private void Serialize<T>(List<T> list, string fileFormat)
        {
            string filePath = string.Empty;

            if (list is List<Book>)
            {
                filePath = bookslbl.Text + fileFormat;
            }

            if (list.First() is Journal)
            {
                filePath = journalslbl.Text + fileFormat;
            }

            if (list.First() is Newspaper)
            {
                filePath = newspaperslbl.Text + fileFormat;
            }

            if (fileFormat == ".xml")
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<T>));

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, list);
                }
            }

            if (fileFormat == ".txt")
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, list);
                }
            }
        }

        private void EnableSaveBtn(object sender, EventArgs e)
        {
            if (booksBox.Text != string.Empty && journalsBox.Text != string.Empty && newspapersBox.Text != string.Empty)
            {
                saveBtn.Enabled = true;
            }
        }
    }
}
