using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcApplicationDemo.Startup))]
namespace MvcApplicationDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
