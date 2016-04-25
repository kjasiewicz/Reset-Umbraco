using System.Web.Optimization;
using Umbraco.Core;

namespace Strona_RESET_Umbraco.Core
{
    public class MyStartupHandler : ApplicationEventHandler
    {
        protected override void ApplicationStarted(
            UmbracoApplicationBase umbracoApplication,
            ApplicationContext applicationContext)
        {
            base.ApplicationStarted(umbracoApplication,applicationContext);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}