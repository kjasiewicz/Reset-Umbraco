using System;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace Strona_RESET_Umbraco.Core
{
    public class ResetCustomTagResolver
    {
        public static string GetTagsString(RenderModel current)
        {
            var pageTags = GetDefaultTags();

            AddTagsToHashSet(current.Content, pageTags);
            foreach (var publishedContent in current.Content.Children)
            {
                AddTagsToHashSet(publishedContent, pageTags);
            }

            return pageTags.Aggregate((a, b) => a + ", " + b);
        }

        private static void AddTagsToHashSet(IPublishedContent content, ISet<string> tags)
        {
            var tagsProperty = content.Properties.FirstOrDefault(x => x.PropertyTypeAlias == "tags");
            if (tagsProperty != null)
            {
                var tagsString = tagsProperty.DataValue.ToString();
                var tagsSplitted = tagsString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var s in tagsSplitted)
                {
                    tags.Add(s);
                }
            }
        }

        private static ISet<string> GetDefaultTags()
        {
            return new HashSet<string>
            {
                "Reset ATH",
                "RESET",
                "Akademia Techniczno Humanistyczna",
                "Koło Informatyczne Reset",
                "Koło Reset",
                "Technologie .NET",
                "Systemy Operacyjne",
                "ITAD",
                "IT Academic Day",
                "ITAD Bielsko",
                "Reset Bielsko",
                "RESET BB"
            };
        }
    }
}
