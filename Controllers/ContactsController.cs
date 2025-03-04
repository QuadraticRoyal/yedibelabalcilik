using Microsoft.AspNetCore.Mvc;
using BalKasar.Models; // Eğer Product modeli buradaysa ekle
using System.Collections.Generic;

namespace BalKasar.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }}