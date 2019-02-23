using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoEventos.Startup))]
namespace ProyectoEventos
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
