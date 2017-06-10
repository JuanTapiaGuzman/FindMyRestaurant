using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FindMyRestaurant.Startup))]
namespace FindMyRestaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
