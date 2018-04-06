using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManageStaff.Startup))]
namespace ManageStaff
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
