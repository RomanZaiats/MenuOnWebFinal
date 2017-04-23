using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MenuOnWebFinal.Startup))]
namespace MenuOnWebFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
