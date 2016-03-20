using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(localHostASPWebApplication.Startup))]
namespace localHostASPWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
