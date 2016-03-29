using System.Linq;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Core;
using Umbraco.Core.Models;
using System.Collections.Generic;
using Strona_RESET_Umbraco.Models;

namespace Strona_RESET_Umbraco.SurfaceControllers
{
    public class HomeController : RenderMvcController
    {
        public ActionResult Index(NewsReturnModel model)
        {
            var requestModel = new NewsRequestModel
            {
                Page = 1
            };
            model.News = GetNews(requestModel, model);
            return CurrentTemplate(model);
        }

        private static IEnumerable<IPublishedContent> GetNews(NewsRequestModel requestModel, NewsReturnModel model)
        {
            if (requestModel == null || requestModel.Page == default(int))
            {
                return new List<IPublishedContent>();
            };

            return model.Content.Children.OrderByDescending(x => x.CreateDate)
                .Skip((requestModel.Page-1) * requestModel.PageSize)
                .Take(requestModel.PageSize).ToList();
        }
    }
}