using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hopper.Startup))]
namespace Hopper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
