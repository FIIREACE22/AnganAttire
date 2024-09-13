using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnganAttire.Web.Startup))]
namespace AnganAttire.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
