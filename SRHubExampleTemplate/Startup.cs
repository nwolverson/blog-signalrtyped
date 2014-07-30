using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SRHubsTT.Startup))]
namespace SRHubsTT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
