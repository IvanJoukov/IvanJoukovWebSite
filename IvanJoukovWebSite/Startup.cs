using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IvanJoukovWebSite.Startup))]
namespace IvanJoukovWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
