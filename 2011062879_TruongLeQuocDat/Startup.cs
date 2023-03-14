using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2011062879_TruongLeQuocDat.Startup))]
namespace _2011062879_TruongLeQuocDat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
