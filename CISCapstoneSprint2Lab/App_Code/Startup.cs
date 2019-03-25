using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CISCapstoneSprint2Lab.Startup))]
namespace CISCapstoneSprint2Lab
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
