using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DashboardDemo.Startup))]
namespace DashboardDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
