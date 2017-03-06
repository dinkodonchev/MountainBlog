namespace MountainBlog.Data
{
    using MountainBlog.Data.Repositories;
    using MountainBlog.Models;

    public interface IMountainBlogData
    {
        IRepository<ApplicationUser> Users
        {
            get;
        }

        IRepository<Post> Posts
        {
            get;
        }

    }
}
