using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IhopNet.Startup))]
namespace IhopNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
