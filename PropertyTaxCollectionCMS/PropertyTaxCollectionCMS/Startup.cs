using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PropertyTaxCollectionCMS.Startup))]
namespace PropertyTaxCollectionCMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
