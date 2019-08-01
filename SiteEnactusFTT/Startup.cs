using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteEnactusFTT.Startup))]
namespace SiteEnactusFTT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
