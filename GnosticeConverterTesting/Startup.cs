using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GnosticeConverterTesting.Startup))]
namespace GnosticeConverterTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
