using System.Web;
using System.Web.Optimization;

namespace Template.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular/angular.min.js",
                "~/Scripts/angular/angular-route.js",
                "~/Scripts/angular/angular-cookies.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularUIBootstrap").Include(
                "~/Scripts/angular-ui/ui-bootstrap.min.js",
                "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularApp").IncludeDirectory(
                "~/AngularApp", "*.js", true));

            bundles.Add(new ScriptBundle("~/bundles/angularModules").Include(
                "~/Scripts/angular-local-storage/angular-local-storage.min.js",
                "~/Scripts/angulartics/angulartics.min.js", 
                "~/Scripts/angulartics/angulartics-ga.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/externalLibs").Include(
                "~/Scripts/lodash/lodash.min.js"));
        }
    }
}
