namespace MountainBlog.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using MountainBlog.Data.Repositories;
    using MountainBlog.Models;

    public class MountainBlogData : IMountainBlogData
    {
        private DbContext context;
        private Dictionary<Type, object> repositories;

        public MountainBlogData()
            : this(new MountainBlogDbContext())
        {
        }

        public MountainBlogData(DbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<ApplicationUser> Users
        {
            get
            {
                return this.GetRepository<ApplicationUser>();
            }
        }

        public IRepository<Post> Posts
        {
            get
            {
                return this.GetRepository<Post>();
            }
        }


        private IRepository<T> GetRepository<T>() where T : class
        {
            var typeOfRepository = typeof(T);
            if (!this.repositories.ContainsKey(typeOfRepository))
            {
                var newRepository = Activator.CreateInstance(typeof(Repository<T>), context);
                this.repositories.Add(typeOfRepository, newRepository);
            }

            return (IRepository<T>) this.repositories[typeOfRepository];
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }
    }
}
