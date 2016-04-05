using System;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Core.Models;
using System.Collections.Generic;
using Strona_RESET_Umbraco.Models;
using umbraco;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace Strona_RESET_Umbraco.SurfaceControllers
{
    //[Route("~/")]
    //[Route("~/Home")]
    public class HomeController : RenderMvcController
    {
        private const int PageSize = 3;
        private const int Page = 1;

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

            return CurrentTemplate(model);
        }
    }


    public class LayoutController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            return Redirect("/home");
        }
    }

    public class LazyController : SurfaceController
    {
        private const int PageSize = 3;

        public PartialViewResult GetNews(int page, int? pinnedPostId = null)
        {
            var news = Services.ContentService.GetChildrenByName(Services.ContentService.GetRootContent().First().Id, "Home")
                .First()
                .Children()
                .OrderByDescending(x => x.CreateDate)
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


    public class NewsAjaxModel
    {
        public string shortTitle { get; set; }
        public string shortDesc { get; set; }
        public string shortDate { get; set; }
        public string shortIconUrl { get; set; }
        public string url { get; set; }
        public string type { get; set; }
    }

    public static class StringExtensions
    {
        public static string RemoveParagraphs(this string val)
        {
            return val.Replace("<p>", "").Replace("</p>", "");
        }

        public static string RemoveSpanParagraphs(this string val)
        {
            return val.Replace("<span>", "").Replace("</span>", "");
        }
    }
}