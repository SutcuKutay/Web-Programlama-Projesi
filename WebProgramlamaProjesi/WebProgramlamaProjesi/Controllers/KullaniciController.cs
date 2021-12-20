using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaProjesi.Data;
using WebProgramlamaProjesi.Models;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

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
        public IActionResult GirisBasarili()
        {
            if(HttpContext.Session.GetString("KullaniciID") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
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
            Kullanici usr = null;
            usr = _context.Kullanici.Single(u => u.Email == user.Email && u.Sifre == user.Sifre);
            if(usr != null)
            {
                HttpContext.Session.SetString("KullaniciID", usr.KullaniciID.ToString());
                HttpContext.Session.SetString("GercekAd", usr.GercekAd.ToString());
                return RedirectToAction("GirisBasarili");
            }
            else
            {
                ModelState.AddModelError("", "Email yada şifre yanlış.");
                return RedirectToAction("Login");
            }
        }
    }
}
