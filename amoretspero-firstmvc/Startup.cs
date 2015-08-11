using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(amoretspero_firstmvc.Startup))]
namespace amoretspero_firstmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
