using BooksAndJournalsApp.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksAndJournalsApp.View
{
    public partial class CheckAuthorsView : Form
    {
        public CheckAuthorsView(List<string> matchedAuthors)
        {
            InitializeComponent();
            MatchedBox.DataSource = matchedAuthors;
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MatchedBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!YesBtn.Enabled && !NoBtn.Enabled)
            {
                YesBtn.Enabled = true;
                NoBtn.Enabled = true;
            }
        }
    }
}
