using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataTransferToView1.Controllers
{
    public class HomeController : Controller
    {
       //09.04.2019



        public ActionResult Index()
        {
            ViewBag.Baslik = "MVC ile veri gönderimi";
            ViewBag.AdSoyad = "Can canan";
            ViewBag.Sayi1 = 5;
            ViewBag.Sayi2 = 10;
            // açıklama var
            List<string> isimler = new List<string>();
            isimler.Add("CediOsman");
            isimler.Add("Mayk");
            isimler.Add("Izzet");
            isimler.Add("Yasemin");
            isimler.Add("Aslı");
            isimler.Add("Layla");
            // açıklama var

            ViewBag.isimler = isimler;
            // açıklama var
            List<string> soyisimler = new List<string>();
            soyisimler.Add("Osmanoğlu");
            soyisimler.Add("Muratoğlu");
            soyisimler.Add("Ahmetoğlu");
            soyisimler.Add("Cansuoğlu");
            soyisimler.Add("Leylaoğlu");

            ViewData["soyisimler"] = soyisimler;


            TempData["AdSoyad"] = "Can Oğuz";
            return View();
        }


    }
}