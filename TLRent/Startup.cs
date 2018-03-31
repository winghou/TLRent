using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TLRent.Startup))]
namespace TLRent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
