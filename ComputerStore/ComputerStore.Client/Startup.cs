using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComputerStore.Client.Startup))]
namespace ComputerStore.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
