using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BreweryForumTest.Startup))]
namespace BreweryForumTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
