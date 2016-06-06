using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloCode.Startup))]
namespace HelloCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
