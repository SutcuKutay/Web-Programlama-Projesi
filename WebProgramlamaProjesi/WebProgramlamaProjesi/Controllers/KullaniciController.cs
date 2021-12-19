using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaProjesi.Data;
using WebProgramlamaProjesi.Models;

namespace WebProgramlamaProjesi.Controllers
{
    public class KullaniciController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KullaniciController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Basarili()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(Kullanici user)
        {
            if (ModelState.IsValid)
            {
                _context.Kullanici.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Basarili");
            }
            else
            {
                TempData["msj"] = "Basarisiz kayit.";
            }
            return RedirectToAction("Login");
        }
        [HttpPost]
        public IActionResult Giris(Kullanici user)
        {
            return RedirectToAction("Basarili");
        }
    }
}
