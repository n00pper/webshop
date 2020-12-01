using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KertiBolt.Startup))]
namespace KertiBolt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
