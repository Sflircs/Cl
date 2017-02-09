using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CLR.Startup))]
namespace CLR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
