using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoOpenID.Startup))]
namespace DemoOpenID
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
