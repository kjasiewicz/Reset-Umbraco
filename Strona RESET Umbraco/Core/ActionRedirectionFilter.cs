using System.Web;
using System.Web.Mvc;
using umbraco.interfaces;

namespace Strona_RESET_Umbraco.Core
{
    public class ActionRedirectionFilter : ActionFilterAttribute
    {
        private const string ResetArchiveBaseUrl = "http://reset.ath.eu";
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var httpContext = filterContext.RequestContext.HttpContext;
            if (httpContext.Request.Path.EndsWith(".aspx"))
            {
                var baseUrl = string.Format("{0}://{1}", httpContext.Request.Url.Scheme, httpContext.Request.Url.Authority);
                httpContext.Response.RedirectPermanent(httpContext.Request.Url.ToString().Replace(baseUrl,ResetArchiveBaseUrl));
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }


    public class MyNotFoundHandler : INotFoundHandler
    {
        private const string ResetArchiveBaseUrl = "http://reset.ath.eu";


        private int redirectId;

        public bool Execute(string url)
        {

            var baseUrl = string.Format("{0}://{1}", HttpContext.Current.Request.Url.Scheme, HttpContext.Current.Request.Url.Authority);
            if (url.EndsWith(".aspx"))
            {
                HttpContext.Current.Response.RedirectPermanent(HttpContext.Current.Request.Url.ToString().Replace(baseUrl, ResetArchiveBaseUrl));
                return true;
            }
          
            return false;
        }

        public bool CacheUrl
        {
            get { return false; }
        }

        public int redirectID
        {
            get { return redirectId; }
        }
    }
}
