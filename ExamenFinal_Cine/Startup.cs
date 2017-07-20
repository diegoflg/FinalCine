using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Semana13_2_AJAX_Cine.Startup))]
namespace Semana13_2_AJAX_Cine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
