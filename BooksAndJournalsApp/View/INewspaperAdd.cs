using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views
{
    public interface INewspaperAdd
    {
        string Title { get; set; }
        string Publisher { get; set; }
        string Article { get; set; }
    }
}
