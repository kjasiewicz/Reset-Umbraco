using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using Umbraco.Web.Mvc;
using Strona_RESET_Umbraco.Models;

namespace Strona_RESET_Umbraco.SurfaceControllers
{
    public class HomeController : RenderMvcController
    {
        private const int PageSize = 3;
        private const int Page = 1;

        [OutputCache(Duration = int.MaxValue, Location = OutputCacheLocation.Server)]
        public ActionResult Index(NewsReturnModel model)
        {
            model.PinnedNews = model.Content.Children
                .Where(a => Convert.ToBoolean(a.Properties.First(x => x.PropertyTypeAlias == "pinPost").Value))
                .OrderByDescending(x => x.CreateDate)
                .FirstOrDefault();

            model.News = model.Content.Children.OrderByDescending(x => x.CreateDate)
                .Skip((Page - 1) * PageSize)
                .Take(PageSize)
                .Where(x => model.PinnedNews == null || x.Id != model.PinnedNews.Id).ToList();

            return View("home", model);
        }
    }
}