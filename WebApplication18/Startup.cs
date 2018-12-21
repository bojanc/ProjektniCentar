using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication18.Startup))]
namespace WebApplication18
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
