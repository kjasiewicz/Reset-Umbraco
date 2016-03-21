using System.Linq;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Core;

namespace Strona_RESET_Umbraco.SurfaceControllers
{
    public class LazyNewsController : SurfaceController
    {
        public ActionResult Index()
        {
            var homeContentType = ApplicationContext.Current.Services.ContentTypeService.GetContentType("home");

            var homeContent = ApplicationContext.Current.Services.ContentService.GetContentOfContentType(homeContentType.Id).First();
            var childrens = ApplicationContext.Current.Services.ContentService.GetChildren(homeContent.Id);

            return Content("hello world");
        }
    }
}