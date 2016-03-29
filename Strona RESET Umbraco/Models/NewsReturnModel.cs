using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace Strona_RESET_Umbraco.Models
{
    public class NewsReturnModel : RenderModel
    {
        public NewsReturnModel() : base(UmbracoContext.Current.PublishedContentRequest.PublishedContent)
        {

        }

        public IEnumerable<IPublishedContent> News { get; set; }
    }
}