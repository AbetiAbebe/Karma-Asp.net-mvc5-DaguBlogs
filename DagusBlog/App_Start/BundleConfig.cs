﻿using System.Web;
using System.Web.Optimization;

namespace DagusBlog
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            // new script for new admin

            bundles.Add(new ScriptBundle("~/bundles/admin").Include(
                        "~/Scripts/tinymce/tinymce.js"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/jqBootstrapValidation.js",
            //          "~/Scripts/clean-blog.js",
            //          "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/clean-blog.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/admin").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/admin.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/Content/animate.css",
                 //    "~/Styles/Global.js",
                     "~/Scripts/wow.min.js",
                     "~/Content/li-scroller.css",
                     "~/Scripts/jquery.li-scroller.1.0.js",
                     "~/Scripts/jquery.newsTicker.min.js",
                     "~/Scripts/jquery.fancybox.pack.js",
                     "~/Content/jquery.fancybox.css",
                     "~/Scripts/custom.js",
                     "~/Scripts/slick.min.js" ,
                     "~/Scripts/slick.css",
                     "~/Content/theme.css",
                     "~/Content/style.css",
                     "~/Scripts/bootstrap.js",
                     "~/Scripts/jqBootstrapValidation.js",
                     "~/Scripts/clean-blog.js",
                     "~/Scripts/respond.js"));

        }
    }
}
