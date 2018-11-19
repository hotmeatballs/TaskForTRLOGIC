using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TRLogicTask.Startup))]
namespace TRLogicTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
