using System.Web;
using System.Web.Optimization;

namespace WebApiService
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
            //
            //New Theme
            bundles.Add(new ScriptBundle("~/Content/Tema-jsss").Include(
                "~/Content/site/js/html5shiv.js",
                "~/Content/site/js/respond.min.js"

            ));

            bundles.Add(new ScriptBundle("~/Content/Tema-jss").Include(
                "~/Content/site/js/jquery-1.11.1.min.js",
                "~/Content/site/js/modernizr.custom.js",
                "~/Content/Site/js/elementQuery.js"
            ));

            bundles.Add(new ScriptBundle("~/Content/Tema-js3").Include(
                "~/Content/site/js/jquery-ui.js",
                "~/Content/site/js/jquery.flexslider.js",
                "~/Content/site/js/owl.carousel.min.js",
                "~/Content/site/js/jquery.countTo.js",
                "~/Content/site/js/viewportchecker.js",
                "~/Content/site/js/jquery.magnific-popup.min.js",
                "~/Content/site/js/zepto.js",
                "~/Content/site/js/topmenu.js",
                "~/Content/site/js/hoverIntent.js",
                "~/Content/site/js/superfish.js",
                "~/Content/site/js/jquery.fitvids.js",
                "~/Content/site/js/custom.js"
            ));
            bundles.Add(new StyleBundle("~/Content/Tema").Include(
                "~/Content/site/css/font-awesome.min.css",
                "~/Content/site/css/flexslider.css",
                "~/Content/site/css/magnific-popup.css",
                "~/Content/site/css/owl.carousel.css",
                "~/Content/site/css/style.css",

                "~/Content/site/css/responsive.css",
                "~/Content/site/css/layout.css"
            ));
            //
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/polyfill.js",
                     "~/Scripts/bootstrap-tabdrop.js"

                      ));
            bundles.Add(new ScriptBundle("~/bundles/boottap").Include(
                     //"~/Scripts/bootstrap-tabdrop-jquery.js",                   
                     //"~/Scripts/bootstrap-dropdown.js",
                     //"~/Scripts/bootstrap-tab.js",
                     "~/Scripts/bootstrap-tabcollapse.js"
                     ));
            bundles.Add(new ScriptBundle("~/bundles/imgeffect").Include(
                        "~/Content/imgeffect/production.min.js",
                        "~/Scripts/blazy.min.js"
                    ));
            bundles.Add(new StyleBundle("~/bundles/css/imgeffect").Include(
                        "~/Content/imgeffect/effects.min.css"
                    ));
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(

                     "~/Scripts/angular.min.js",
                     "~/Scripts/angular-route.js",
                     "~/Scripts/angular-messages.min.js",
                     "~/Scripts/angular-sanitize.min.js",
                     "~/Scripts/angular-animate.min.js",
                     "~/Scripts/angular-strap.min.js",
                     "~/Scripts/angular-strap.tpl.min.js",
                     "~/Scripts/angular-strap.docs.tpl.min.js",
                     "~/Scripts/ng-infinite-scroll.min.js",
                     "~/Scripts/dirPagination.js",
                     "~/Scripts/me-lazyload.js",

                     "~/Scripts/ui-bootstrap-tpls-0.12.0.js",
                    "~/Content/owlcarousel/ngRepeatOwlCarousel.min.js",
                    "~/Scripts/angular-recaptcha.min.js",
                     "~/Js/app.js",
                     "~/Js/Controller/ImageUpload.js",
                     "~/Js/Services/LoginServices.js",
                     "~/Js/Services/IlanEkleservice.js",
                     "~/Js/Services/KategorilerService.js",
                      "~/Js/Services/WebSiteSevice.js",
                     "~/Js/Services/SaveService.js",
                     "~/Js/Services/ProfilPageService.js",
                     "~/Js/Controller/CheckBoxController.js",
                     "~/Js/Controller/LoginController.js",
                     "~/Js/Controller/RegisterLoginControlController.js",
                     "~/Js/Controller/IlanEkleController.js",
                     "~/Js/Controller/ProfilPageController.js",
                      "~/Js/Controller/WebSiteController.js",
                       "~/Js/Services/MusterilerService.js",
                        "~/Js/Controller/MusterilerController.js",
                     "~/Js/Controller/IlanDetayController.js",
                        "~/Js/Controller/MenuController.js"
                     ));
            bundles.Add(new StyleBundle("~/Content/form").Include(

                    "~/Content/Forms/CheckBoxRadio.css",
                    "~/Content/Forms/FormWizard.css",
                     "~/Content/Forms/FormImput.css",
                     "~/Content/Forms/bootstrap-select.min.css",
                     "~/Content/Forms/DropDownMenu.css"

                    ));
            bundles.Add(new ScriptBundle("~/bundles/formjs").Include(

                      "~/Content/Forms/Js/bootstrap-select.js",
                      "~/Content/Forms/Js/select.js",
                      "~/Content/Forms/Js/validator.js",
                       "~/Content/Forms/Js/GetKategoriAjax.js",
                       "~/Content/Forms/Js/DropDownMenu.js",
                       "~/Content/Forms/Js/FormWizerd.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome-4.7.0/css/font-awesome.css",
                      "~/Content/animate.css",
                      //"~/Content/bootstrap-responsive.css"
                      "~/Content/bootstrap-theme.min.css",
                      "~/Content/site.css"

                      ));
            bundles.Add(new StyleBundle("~/Content/revolutionslider").Include(
                "~/Scripts/revolutionslider/css/fullwidth.css",
                "~/Scripts/revolutionslider/rs-plugin/css/settings.css"
                ));
            bundles.Add(new ScriptBundle("~/bundles/revolutionsliderjs").Include(
                "~/Scripts/revolutionslider/rs-plugin/js/jquery.themepunch.plugins.min.js",
                "~/Scripts/revolutionslider/rs-plugin/js/jquery.themepunch.revolution.min.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/Sitejs").Include(
                "~/Js/Slider/Code.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/DropDownjs").Include(
                "~/Content/Forms/Js/DropDownMenu.js"
            ));
            bundles.Add(new StyleBundle("~/Content/distcss").Include(
                      "~/Content/dist/css/swiper.min.css"
                      ));
            bundles.Add(new ScriptBundle("~/bundles/distjs").Include(
               "~/Content/dist/js/swiper.min.js"
               ));
            bundles.Add(new StyleBundle("~/Content/carouselcss").Include(
                     "~/Content/carousel/angular-carousel.css",
                      "~/Content/carousel/demo.css"
                     ));
            bundles.Add(new ScriptBundle("~/bundles/carouseljs").Include(
               "~/Content/carousel/angular-swipe.js",
                "~/Content/carousel/angular-carousel.js",
                 "~/Content/carousel/demo.js"
               ));
            //Deneme1 Bitti{Olmadı...}
            bundles.Add(new StyleBundle("~/Content/ovlcss").Include(
                //"~/Content/owlcarousel/assets/css/bootstrapTheme.css",
                //"~/Content/owlcarousel/assets/css/custom.css",
                //"~/Content/owlcarousel/owl-carousel/owl.carousel.css",
                //"~/Content/owlcarousel/owl-carousel/owl.theme.css",
                //"~/Content/owlcarousel/owl-carousel/owl.transitions.css",
                //"~/Content/owlcarousel/assets/js/google-code-prettify/prettify.css"
                //"~/Content/owlcarousel/owl-carousel/owl.theme.css",
                "~/Content/site/css/owl.carousel.css"
                    //"~/Content/site/css/owl.theme.default.min.css"
                    //"~/Content/owlcarousel/owl-carousel/owl.transitions.css",
                    //"~/Content/site/css/responsive.css"


                    ));
            bundles.Add(new ScriptBundle("~/bundles/ovljss").Include(
                "~/Content/site/js/owl.carousel.min.js"
               // "~/Content/site/js/owl.js"
               //"~/Content/owlcarousel/owl-carousel/angular-owl-carousel.js"
               ));
            BundleTable.EnableOptimizations = false;
        }
    }
}
