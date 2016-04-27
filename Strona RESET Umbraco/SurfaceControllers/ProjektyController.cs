using System.Web.Mvc;
using System.Web.UI;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Strona_RESET_Umbraco.SurfaceControllers
{
    public class ProjektyController : RenderMvcController
    {
        [OutputCache(Duration = int.MaxValue, Location = OutputCacheLocation.Server)]
        public override ActionResult Index(RenderModel model)
        {
            return base.Index(model);
        }
    }
}