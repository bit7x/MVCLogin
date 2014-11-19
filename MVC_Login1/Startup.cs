using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Login1.Startup))]
namespace MVC_Login1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
