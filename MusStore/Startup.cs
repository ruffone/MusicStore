using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusStore.Startup))]
namespace MusStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
