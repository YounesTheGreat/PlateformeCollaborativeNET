using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlateformeCollaborativeNET_MVC5.Startup))]
namespace PlateformeCollaborativeNET_MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
