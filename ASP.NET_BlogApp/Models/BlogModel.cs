using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Entities;

namespace Models
{
    public partial class BlogModel : DbContext
    {
        public BlogModel()
            : base("name=BlogModelCon")
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Posts)
                .Map(m => m.ToTable("PostsTags").MapLeftKey("PostId").MapRightKey("TagId"));
        }
    }
}
