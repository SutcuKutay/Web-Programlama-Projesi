using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaProjesi.Models
{
    public class Kullanici
    {
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string GercekAd { get; set; }
        public string GercekSoyad { get; set; }
        public string KullaniciAdres { get; set; }
        public int TelefonNo { get; set; }

    }
}
