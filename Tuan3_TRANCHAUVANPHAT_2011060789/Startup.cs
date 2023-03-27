using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuan3_TRANCHAUVANPHAT_2011060789.Startup))]
namespace Tuan3_TRANCHAUVANPHAT_2011060789
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
