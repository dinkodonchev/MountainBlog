using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MountainBlog.Startup))]
namespace MountainBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
