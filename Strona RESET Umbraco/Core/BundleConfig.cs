using System.Web.Optimization;

namespace Strona_RESET_Umbraco.Core
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.migrate.js",
                        "~/Scripts/jquery.fitvids.js",
                        "~/Scripts/jquery.appear.js",
                        "~/Scripts/jquery.parallax.js",
                        "~/Scripts/jquery.slicknav.js",
                        "~/Scripts/jquery.isotope.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/nivo-lightbox.js",
                        "~/Scripts/script.js", 
                        "~/Scripts/custom.js"
                       ));


            bundles.Add(new StyleBundle("~/bundles/css").Include(
                         "~/css/bootstrap.css",
                         "~/css/font-awesome.min.css",
                         "~/css/slicknav.css",
                         "~/css/style.css",
                         "~/css/hover.css",
                         "~/css/responsive.css",
                         "~/css/animate.css",
                         "~/css/red.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
