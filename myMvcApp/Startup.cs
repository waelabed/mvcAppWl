using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myMvcApp.Startup))]
namespace myMvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
