using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppliLogo.Startup))]
namespace AppliLogo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
