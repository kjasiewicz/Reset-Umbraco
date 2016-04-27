using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using Strona_RESET_Umbraco.Core;
using umbraco;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace Strona_RESET_Umbraco.SurfaceControllers
{
    public class LazyController : SurfaceController
    {
        private const int PageSize = 3;

        [OutputCache(Duration = int.MaxValue, Location = OutputCacheLocation.Server, VaryByParam = "page")]
        public PartialViewResult GetNews(int page, int? pinnedPostId = null)
        {
            var news = Services.ContentService.GetChildrenByName(Services.ContentService.GetRootContent().First().Id, "Home")
                .First()
                .Children()
                .OrderByDescending(x => x.CreateDate)
                .Where(x=>x.Published)
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
                .Where(x => pinnedPostId == null || x.Id != pinnedPostId.Value)
                .ToList();

            var model = PrepareModel(news);
            return PartialView(model);
        }

        private static List<NewsAjaxModel> PrepareModel(IEnumerable<IContent> news)
        {
            var umbracoHelper = new UmbracoHelper(UmbracoContext.Current);

            return news.Select(content => new NewsAjaxModel
            {
                shortDesc = content.Properties.First(x => x.Alias == "shortDesc").Value.ToString().RemoveParagraphs(),
                shortDate = content.Properties.First(x => x.Alias == "shortDate").Value.ToString().RemoveParagraphs(),
                shortTitle = content.Properties.First(x => x.Alias == "shortTitle").Value.ToString().RemoveParagraphs(),
                shortIconUrl = umbracoHelper.TypedMedia(content.Properties.First(x => x.Alias == "shortIcon").Value).Url,
                url = library.NiceUrl(Convert.ToInt32(content.Id)),
                type = content.Properties.First(x => x.Alias == "typeDropdown").Value.ToString().RemoveParagraphs()
            }).ToList();
        }
    }
}
