using System;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Core.Models;
using System.Collections.Generic;
using Strona_RESET_Umbraco.Models;
using umbraco;
using Umbraco.Web;

namespace Strona_RESET_Umbraco.SurfaceControllers
{
    //[Route("~/")]
    //[Route("~/Home")]
    public class HomeController : RenderMvcController
    {
        private const int PageSize = 1;
        private const int Page = 1;

        public ActionResult Index(NewsReturnModel model)
        {
            
            model.News = model.Content.Children.OrderByDescending(x => x.CreateDate)
                .Skip((Page - 1) * PageSize)
                .Take(PageSize).ToList();
            return CurrentTemplate(model);
        }
    }


    public class LazyController : SurfaceController
    {
        private const int PageSize = 1;

        public PartialViewResult GetNews(int page)
        {
            var news = Services.ContentService.GetChildrenByName(Services.ContentService.GetRootContent().First().Id, "Home")
                .First()
                .Children()
                .OrderByDescending(x => x.CreateDate)
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
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
    }
}