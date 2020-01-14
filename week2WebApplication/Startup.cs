using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(week2WebApplication.Startup))]
namespace week2WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
