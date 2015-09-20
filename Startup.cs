using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MBukowski.Startup))]
namespace MBukowski
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
