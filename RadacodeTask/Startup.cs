using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RadacodeTask.Startup))]
namespace RadacodeTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
