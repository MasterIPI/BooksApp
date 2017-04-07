using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public interface IDeleJournalView
    {
        List<Journal> Journals { get; set; }
        DataGridViewRow CurrentRow { get; set; }
    }
}
