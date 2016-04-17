using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DC.Startup))]
namespace DC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
