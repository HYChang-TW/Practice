using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(P1.Startup))]
namespace P1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
