using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CAPE.Startup))]
namespace CAPE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
