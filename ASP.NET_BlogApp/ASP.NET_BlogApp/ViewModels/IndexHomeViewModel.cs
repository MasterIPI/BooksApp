using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_BlogApp.Models
{
    public class IndexHomeViewModel
    {
        public int PostsPerPage { get; } = 4;
        public IEnumerable<Post> Posts { get; set; }
        public bool IsPreviousLinkVisible { get; set; }
        public bool IsNextLinkVisible { get; set; }
        public int PageNumber { get; set; }
    }
}