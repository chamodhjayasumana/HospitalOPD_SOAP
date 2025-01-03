using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HospitalOPD_SOAP.Startup))]
namespace HospitalOPD_SOAP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
