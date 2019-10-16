using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Superstore.Startup))]
namespace Superstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
