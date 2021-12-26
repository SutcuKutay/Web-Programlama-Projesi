using Microsoft.AspNetCore.Mvc;
using WebProgramlamaProjesi.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaProjesi.Data;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebProgramlamaProjesi.Controllers
{
    public class UrunController1 : Controller
    {
        private ApplicationDbContext db;
        public UrunController1(ApplicationDbContext tmp)
        {
            db = tmp;
        }
        public IActionResult Index()
        {
            var defaultCultures = new List<CultureInfo>()
            {
                new CultureInfo("tr-TR"),
                new CultureInfo("en-US"),
            };

            CultureInfo[] cinfo = CultureInfo.GetCultures(CultureTypes.AllCultures);
            var cultureItems = cinfo.Where(x => defaultCultures.Contains(x))
                .Select(c => new SelectListItem { Value = c.Name, Text = c.DisplayName })
                .ToList();
            ViewData["Cultures"] = cultureItems;
            ViewData["Urunler"] = db.Urun.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult UrunEkle(Urun urun, IFormFile files)
        {
            using (var target = new MemoryStream())
            {
                files.CopyTo(target);
                urun.rsm = target.ToArray();
            }
            db.Urun.Add(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Sil(string Id)
        {
            db.Urun.Remove(db.Urun.Find(Int32.Parse(Id)));
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
