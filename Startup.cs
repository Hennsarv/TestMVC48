using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVC48.Startup))]
namespace TestMVC48
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
