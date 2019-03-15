using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PreparationExamen.Startup))]
namespace PreparationExamen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
