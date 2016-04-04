using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core;

namespace Strona_RESET_Umbraco.Core
{
    public class MyStartupHandler : ApplicationEventHandler
    {
        protected override void ApplicationStarted(
            UmbracoApplicationBase umbracoApplication,
            ApplicationContext applicationContext)
        {
            ////Create a custom route
            //RouteTable.Routes.MapRoute(
            //    "Base",
            //    "",
            //    new
            //    {
            //        controller = "Home",
            //        action = "Index"
            //    },
            //    new
            //    {
            //        controller = "Home",
            //        action = "Index"
            //    });
        }
    }
}