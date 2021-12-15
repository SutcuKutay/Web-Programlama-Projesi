using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProjesi.Models
{
    public class Yorum
    {
        [Key]
        public int YorumID { get; set; }

        public string Metin { get; set; }

        [ForeignKey("KullaniciID")]
        public Kullanici YorumYapan { get; set; }
    }
}
