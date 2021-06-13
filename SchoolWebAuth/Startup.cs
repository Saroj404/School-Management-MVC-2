using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolWebAuth.Startup))]
namespace SchoolWebAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
