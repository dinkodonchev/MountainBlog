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
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<TrackingSystemDbContext, Configuration>());
        }

        IDbSet<ApplicationUser> Users
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
