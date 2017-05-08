using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnableIt.Web.Startup))]
namespace EnableIt.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
