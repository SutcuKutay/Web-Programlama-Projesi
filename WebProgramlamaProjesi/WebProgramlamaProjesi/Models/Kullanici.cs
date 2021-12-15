using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaProjesi.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string GercekAd { get; set; }
        public string GercekSoyad { get; set; }
        public string KullaniciAdres { get; set; }
        public string TelefonNo { get; set; }

    }
}
