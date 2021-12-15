using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProjesi.Models
{
    public class Kategoriler
    {
        [Key]
        public int KategoriId { get; set; }
        
        public string KategoriAd { get; set; }


    }
}
