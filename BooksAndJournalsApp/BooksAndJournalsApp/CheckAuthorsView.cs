using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Forms.View
{
    public partial class CheckAuthorsView : Form
    {
        public CheckAuthorsView(List<string> matchedAuthors)
        {
            InitializeComponent();
            MatchedBox.DataSource = matchedAuthors;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
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
