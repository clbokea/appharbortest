using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(appharborgithub.Startup))]
namespace appharborgithub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
