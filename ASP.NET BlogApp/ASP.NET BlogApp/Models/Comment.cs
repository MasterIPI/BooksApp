namespace ASP.NET_BlogApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comment
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        [StringLength(128)]
        public string Email { get; set; }

        [Required]
        public string Body { get; set; }

        public virtual Post Post { get; set; }
    }
}
