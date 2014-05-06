using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WaletzkoPortfolio.Startup))]
namespace WaletzkoPortfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
