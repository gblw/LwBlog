using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gblwBlog.Startup))]
namespace gblwBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
