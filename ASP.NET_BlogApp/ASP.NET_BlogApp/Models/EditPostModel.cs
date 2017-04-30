using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP.NET_BlogApp.Models
{
    public class EditPostModel
    {
        public Post Post { get; set; }
        public string TagsList { get; set; } 
    }
}