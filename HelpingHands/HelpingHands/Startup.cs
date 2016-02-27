using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlCoApp.Startup))]
namespace AlCoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
