using System.Web;
using System.Web.Optimization;

namespace MainApplication
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/jquery-1.8.2.js").Include("~/Scripts/jquery-1.8.2.js"));
            bundles.Add(new ScriptBundle("~/Scripts/html5.js").Include("~/Scripts/html5.js"));
            bundles.Add(new ScriptBundle("~/Scripts/jquery.easing.1.3.js").Include("~/Scripts/jquery.easing.1.3.js"));
            bundles.Add(new ScriptBundle("~/Scripts/tms-0.4.1.js").Include("~/Scripts/tms-0.4.1.js"));

            bundles.Add(new StyleBundle("~/Content/ie.css").Include("~/Content/ie.css"));
            bundles.Add(new StyleBundle("~/Content/reset.css").Include("~/Content/reset.css"));
            bundles.Add(new StyleBundle("~/Content/slider.css").Include("~/Content/slider.css"));
            bundles.Add(new StyleBundle("~/Content/style.css").Include("~/Content/style.css"));
          
        }
    }
}