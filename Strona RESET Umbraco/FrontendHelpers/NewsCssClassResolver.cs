namespace Strona_RESET_Umbraco.FrontendHelpers
{
    public static class NewsCssClassResolver
    {
        public static string GetMixItUpCategoryCssClass(string newsType)
        {
            switch (newsType)
            {
                case "Wykład":
                {
                    return "category-lectures";
                }
                case "Konferencja":
                    {
                        return "category-conference";
                    }
                case "Sukces":
                    {
                        return "category-success";
                    }

                case "Inne":
                default:
                {
                    return "category-other";
                }
            }
        }
    }
}