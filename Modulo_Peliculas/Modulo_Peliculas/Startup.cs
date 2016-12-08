using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Modulo_Peliculas.Startup))]
namespace Modulo_Peliculas
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
