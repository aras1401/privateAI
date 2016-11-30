using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AI_Lib.Startup))]
namespace AI_Lib
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
