using System.Web;
using System.Web.Optimization;

namespace Condorcet.Eshop
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jscore").Include(
                    "~/Content/plugins/jquery-2.2.3.min.js",
                    "~/Content/plugins/jquery.easing.1.3.js",
                    "~/Content/plugins/jquery.cookie.js",
                    "~/Content/plugins/jquery.appear.js",
                    "~/Content/plugins/jquery.isotope.js",
                    "~/Content/plugins/masonry.js",
                    "~/Content/plugins/bootstrap/js/bootstrap.min.js",
                    "~/Content/plugins/magnific-popup/jquery.magnific-popup.min.js",
                    "~/Content/plugins/owl-carousel/owl.carousel.min.js",
                    "~/Content/plugins/stellar/jquery.stellar.min.js",
                    "~/Content/plugins/knob/js/jquery.knob.js",
                    "~/Content/plugins/jquery.backstretch.min.js",
                    "~/Content/plugins/superslides/dist/jquery.superslides.min.js",
                    "~/Content/plugins/mediaelement/build/mediaelement-and-player.min.js",
                    "~/Content/plugins/slider.revolution.v4/js/jquery.themepunch.tools.min.js",
                    "~/Content/plugins/slider.revolution.v4/js/jquery.themepunch.revolution.min.js",
                    "~/js/slider_revolution.js",
                    "~/js/scripts.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/core").Include(
                    "~/Content/plugins/bootstrap/css/bootstrap.min.css",
                    "~/Content/css/font-awesome.css",
                    "~/Content/plugins/owl-carousel/owl.carousel.css",
                    "~/Content/plugins/owl-carousel/owl.theme.css",
                    "~/Content/plugins/owl-carousel/owl.transitions.css",
                    "~/Content/plugins/magnific-popup/magnific-popup.css",
                    "~/Content/css/animate.css",
                    "~/Content/css/superslides.css",
                    "~/Content/plugins/slider.revolution.v4/css/settings.css",
                    "~/Content/css/essentials.css",
                    "~/Content/css/layout.css",
                    "~/Content/css/layout-responsive.css",
                    "~/Content/css/shop.css",
                    "~/Content/css/color_scheme/orange.css"));
        }
    }
}
