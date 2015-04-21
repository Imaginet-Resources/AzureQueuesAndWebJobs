using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Imaginet.Samples.WebSite.Startup))]
namespace Imaginet.Samples.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
