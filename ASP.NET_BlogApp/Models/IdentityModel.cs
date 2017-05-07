using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Entities;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Model
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        public ApplicationDbContext()
            : base("BlogModelCon", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
