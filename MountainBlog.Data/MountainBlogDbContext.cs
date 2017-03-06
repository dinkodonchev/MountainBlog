namespace MountainBlog.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    //using MountainBlog.Data.Migrations;
    using MountainBlog.Models;

    public class MountainBlogDbContext : IdentityDbContext
    {
        public MountainBlogDbContext()
            : base("MountainBlogConnection")
        {
            Database.SetInitializer<MountainBlogDbContext>(null);
        }

        IDbSet<ApplicationUser> Users
        {
            get;
            set;
        }

        IDbSet<Post> Posts
        {
            get;
            set;
        }



        public static MountainBlogDbContext Create()
        {
            return new MountainBlogDbContext();
        }
    }
}
