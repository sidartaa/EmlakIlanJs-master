using System.Web.Mvc;
using TorbaliBurada.Controller;

namespace WebApiService.Controllers
{
    [FooFilter]
    // [DisableThrottling]
    public class HomeController : Controller
    {
       
        public ActionResult Index()

        {

            ViewBag.Title = "Torbalı Burada";

            return View();
        }

        public ActionResult AnaSayfa()
        {
            return PartialView("_anaSayfa");
        }
        public ActionResult Ilanlar()
        {
            ViewBag.Title = "Torbalı Burada";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Title = "Torbalı Burada";

            return View();
        }
        public ActionResult Register()
        {
            ViewBag.Title = "Torbalı Burada";

            return View();
        }

        public ActionResult ProfilPage()
        {
            ViewBag.Title = "Torbalı Burada";

            return View();
        }

        public ActionResult ManageUser()
        {
            ViewBag.Title = "Torbalı Burada";

            return View();
        }

        public ActionResult Musteriler()
        {
            return PartialView("_Musteriler");
        }
        public ActionResult MusteriEkle()
        {
            return PartialView("_MusteriEkle");
        }
        public ActionResult MusteriIlan()
        {
            return PartialView("_MusteriIlan");
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult IlanDetay(int id)
        {
            ViewBag.Title = "Torbalı Burada";
            ViewBag.Id = id;

            return PartialView("IlanDetay");
        }
        public ActionResult DetailSearch()
        {
            ViewBag.Title = "Detaylı Arama";

            return View();
        }
        public ActionResult KategoriCheckBox()
        {
            return PartialView("Kategoriler/_KategorilerCheckBox");
        }

        public ActionResult SatilikKiralikCheckBox()
        {
            return PartialView("Kategoriler/_SatilikKiralikCheckBox");
        }
        public ActionResult LocationCheckBox()
        {
            return PartialView("Kategoriler/_LocationCheckBox");
        }
        public ActionResult KategorilerDropDownMenu()
        {
            return PartialView("Kategoriler/_KategorilerDropDownMenu"); 
        }
        public ActionResult SatilikKiralikDropDownMenu()
        {
            return PartialView("Kategoriler/_SatilikKiralikDropDownMenu");
        }
        public ActionResult LocationDropDownMenu()
        {
            return PartialView("Kategoriler/_LocationDropDownMenu");
        }
        public ActionResult KonutTurDropDownMenu()
        {
            return PartialView("Kategoriler/_KonutTurDropDownMenu");
        }
        public ActionResult ArsaImarDurumuDropDownMenu()
        {
            return PartialView("Arsa/_ArsaImarDurumuDropDownMenu");
        }
        public ActionResult ArsaTapuDurumuDropDownMenu()
        {
            return PartialView("Arsa/_ArsaTapuDurumuDropDownMenu");
        }

        public ActionResult IsyeriTuruDropDownMenu()
        {
            return PartialView("Isyeri/_IsyeriTuruDropDownMenu"); 
        }

    }
}
