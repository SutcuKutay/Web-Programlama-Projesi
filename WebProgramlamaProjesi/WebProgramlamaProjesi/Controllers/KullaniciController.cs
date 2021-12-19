using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaProjesi.Models;

namespace WebProgramlamaProjesi.Controllers
{
    public class KullaniciController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(Kullanici user)
        {
            if (ModelState.IsValid)
            {
                //veri tabani kayit vb.
                TempData["msj"] = "Kayit islemi basarili.";
            }
            else
            {
                TempData["msj"] = "Basarisiz kayit.";
            }
            return RedirectToAction("Login");
        }
    }
}
