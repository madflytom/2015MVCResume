using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tomstahl.Startup))]
namespace tomstahl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
