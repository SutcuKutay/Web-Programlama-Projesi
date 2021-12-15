using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProgramlamaProjesi.Models
{
    public class Urun
    {
        public int UrunId { get; set; }

        public string Ad { get; set; }

        public int Fiyat { get; set; }

        public int Stok { get; set; }

        public string Aciklama { get; set; }

        [ForeignKey("KategoriID")]
        public Kategoriler Kategori { get; set; }

        [ForeignKey("KullaniciID")]
        public Kullanici Kullanici { get; set; }
    }
}
