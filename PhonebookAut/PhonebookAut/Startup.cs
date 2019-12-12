using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhonebookAut.Startup))]
namespace PhonebookAut
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
