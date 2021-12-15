using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProgramlamaProjesi.Models
{
    public class Yorum
    {
        public int YorumID { get; set; }

        public string Metin { get; set; }

        [ForeignKey("KullaniciID")]
        public Kullanici YorumYapan { get; set; }

        [ForeignKey("KullaniciID")]
        public Kullanici YorumYapilan { get; set; }
    }
}
