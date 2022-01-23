using System.Web;
using System.Web.Optimization;

namespace MVC5
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/mycss").Include(
                        
                                "~/Scripts/vendors/bootstrap/dist/css/bootstrap.min.css"
                                ,"~/Scripts/vendors/font-awesome/css/font-awesome.min.css"
                                ,"~/Scripts/vendors/nprogress/nprogress.css"
                                ,"~/Scripts/vendors/iCheck/skins/flat/green.css"
                                , "~/Scripts/vendors/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css"
                                , "~/Content/build/css/custom.min.css"
                                , "~/Scripts/vendors/jqvmap/dist/jqvmap.min.css"
                                , "~/Scripts/vendors/bootstrap-daterangepicker/daterangepicker.css"
                                )) ;




            bundles.Add(new ScriptBundle("~/bundles/myScripts").Include(
              "~/Scripts/vendors/jquery/dist/jquery.min.js"
               ,"~/Scripts/vendors/bootstrap/dist/js/bootstrap.bundle.min.js" 
               ,"~/Scripts/vendors/fastclick/lib/fastclick.js" 
               ,"~/Scripts/vendors/nprogress/nprogress.js"
               ,"~/Scripts/vendors/Chart.js/dist/Chart.min.js"
               ,"~/Scripts/vendors/gauge.js/dist/gauge.min.js"
               ,"~/Scripts/vendors/bootstrap-progressbar/bootstrap-progressbar.min.js"
               ,"~/Scripts/vendors/iCheck/icheck.min.js"
               ,"~/Scripts/vendors/skycons/skycons.js"
               ,"~/Scripts/vendors/Flot/jquery.flot.js"
               ,"~/Scripts/vendors/Flot/jquery.flot.pie.js"
               ,"~/Scripts/vendors/Flot/jquery.flot.time.js"
               ,"~/Scripts/vendors/Flot/jquery.flot.stack.js"
               ,"~/Scripts/vendors/Flot/jquery.flot.resize.js"
               ,"~/Scripts/vendors/flot.orderbars/js/jquery.flot.orderBars.js"
               ,"~/Scripts/vendors/flot-spline/js/jquery.flot.spline.min.js"
               ,"~/Scripts/vendors/flot.curvedlines/curvedLines.js"
               ,"~/Scripts/vendors/DateJS/build/date.js"
               ,"~/Scripts/vendors/jqvmap/dist/jquery.vmap.js"
               ,"~/Scripts/vendors/jqvmap/dist/maps/jquery.vmap.world.js"
               ,"~/Scripts/vendors/jqvmap/examples/js/jquery.vmap.sampledata.js"
               ,"~/Scripts/vendors/moment/min/moment.min.js" 
               ,"~/Scripts/vendors/bootstrap-daterangepicker/daterangepicker.js"
               ,"~/Content/build/js/custom.min.js"
                 ));



        }
    }
}
