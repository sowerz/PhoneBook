using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhonebookAuth.Startup))]
namespace PhonebookAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
