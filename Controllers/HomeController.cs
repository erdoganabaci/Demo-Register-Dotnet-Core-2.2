using System;
using Microsoft.AspNetCore.Mvc;

namespace courseApp2.Controllers
{
    public class HomeController : Controller
    {
        //action method uygulama 2 aşamadan oluşuyor controller = course ve action = methodlar ındex , list gibi
        public IActionResult Index() //donüs tipi return View ise fonksiyonda view tipinde action result olur yani View = IactionResult
        {
            int saat = DateTime.Now.Hour; //viewbag den sonra değişken adı viewbag.erdo
            ViewBag.Saat = saat;
            ViewBag.Greeting = saat > 12 ? "iyi günler" : "Günaydın";
            ViewBag.Username = "Erdoğan"; //viewlara bilgileri gönderebiliyoruz çantalarla
            return View();
        }
        //localjost:500/home/about kullanıcı linki çağırınca yani route edince => home/about.cshtml geliyor.View klasörü altındaki 
        public IActionResult About()
        {
            return View();
        }

    }
}