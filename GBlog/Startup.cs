using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GBlog.Startup))]
namespace GBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
