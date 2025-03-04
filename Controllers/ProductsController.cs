using Microsoft.AspNetCore.Mvc;
using BalKasar.Models; // Eğer Product modeli buradaysa ekle
using System.Collections.Generic;

namespace BalKasar.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }


  public IActionResult Honey()
{
    var products = new List<Product> // Örnek veri oluşturuluyor
    {
        new Product { Name = "Karakovan Balı Süzme ve Çıta",  ImageUrl = Url.Content("~/images/karakovan.png"), },
         new Product { Name = "Çiçek Balı Petek ve Süzme",   ImageUrl = Url.Content("~/images/cicekbali.png"), ImageUrl1 = Url.Content("~/images/cicekbali1.png")  },
      
    };

    return View(products); // Boş olmayan bir model gönderiliyor
}



public IActionResult Cheese()
{
    var products = new List<Product> // Örnek veri oluşturuluyor
    {
        new Product { Name = "Eski Kaşar Peyniri",  ImageUrl = Url.Content("~/images/eskikasar.png"), ImageUrl1 = Url.Content("~/images/eskikasar1.png")},
        new Product { Name = "Kars Gravyer Peyniri",  ImageUrl = Url.Content("~/images/gravyer.png"), ImageUrl1 = Url.Content("~/images/gravyer1.png") },
        new Product { Name = "Yeşil Küflü Peynir",  ImageUrl = Url.Content("~/images/kuflupeynir.png"), ImageUrl1 = Url.Content("~/images/kuflupeynir1.png") },
         new Product { Name = "Köy Peyniri",  ImageUrl = Url.Content("~/images/beyazkoypeyniri.png"), ImageUrl1 = Url.Content("~/images/beyazkoypeyniri1.png") },
        
    };

    return View(products); // Boş olmayan bir model gönderiliyor
}

public IActionResult Butter()
{
    var products = new List<Product> // Örnek veri oluşturuluyor
    {
        new Product { Name = "Tereyağı",  ImageUrl = Url.Content("~/images/tereyagi.png")},
        new Product { Name = "Köy Tereyağı",  ImageUrl = Url.Content("~/images/koytereyagi.png") },

        
    };

    return View(products); // Boş olmayan bir model gönderiliyor
}

public IActionResult TDD()
{
    var products = new List<Product> // Örnek veri oluşturuluyor
    {
        new Product { Name = "Köme",   ImageUrl = Url.Content("~/images/kome.png")},
        new Product { Name = "Dut Kurusu",  ImageUrl = Url.Content("~/images/dutkurusu.png") },
        new Product { Name = "Kayısı Açma",   ImageUrl = Url.Content("~/images/acma.png")},
         new Product { Name = "Pestil",  ImageUrl = Url.Content("~/images/pestil.png")},

        
    };

    return View(products); // Boş olmayan bir model gönderiliyor
}

public IActionResult Meat()
{
    var products = new List<Product> // Örnek veri oluşturuluyor
    {
        new Product { Name = "Kars Kazı",  ImageUrl = Url.Content("~/images/kaz.png"), ImageUrl1 = Url.Content("~/images/kaz1.png")},



        
    };

    return View(products); // Boş olmayan bir model gönderiliyor
}


}
}
