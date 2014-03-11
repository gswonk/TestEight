using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webAppOne.Startup))]
namespace webAppOne
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
