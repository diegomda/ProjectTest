using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteoHorario.Startup))]
namespace TesteoHorario
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
