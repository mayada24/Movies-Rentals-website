using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Home_Of_Movies.Startup))]
namespace Home_Of_Movies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
