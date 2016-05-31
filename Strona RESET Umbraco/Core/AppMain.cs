using System;
using System.Web.Mvc;

namespace Strona_RESET_Umbraco.Core
{
    public class AppMain : Umbraco.Web.UmbracoApplication
    {

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        protected override void OnApplicationStarted(object sender, EventArgs e)
        {
            base.OnApplicationStarted(sender, e);

            GlobalFilters.Filters.Add(new ActionRedirectionFilter());
            RegisterGlobalFilters(GlobalFilters.Filters);

        }
    }

}
