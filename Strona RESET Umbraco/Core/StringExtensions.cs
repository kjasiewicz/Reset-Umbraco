using System.Text.RegularExpressions;

namespace Strona_RESET_Umbraco.Core
{
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
        public static string RemoveHtmlTags(this string val)
        {
            return Regex.Replace(val, "<.*?>", string.Empty);
        }

    }
}