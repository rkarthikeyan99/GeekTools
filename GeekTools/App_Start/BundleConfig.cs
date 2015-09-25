using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace GeekTools.App_Start
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = false;
            bundles.IgnoreList.Clear();

            bundles.Add(new ScriptBundle("~/bundles/Site").Include(
                       "~/Scripts/main.js",
                        "~/Scripts/picturefill.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/jquery-validate.js",
                     "~/Scripts/jquery-validate.unobtrusive.js",
                      "~/Scripts/jquery-browser.js"));


            bundles.Add(new StyleBundle("~/bundles/Css").Include(
                      "~/Content/fonts.css",
                      "~/Content/Site.css",
                       "~/Content/main.css",
                        "~/Content/print.css"));
        }
    }
}