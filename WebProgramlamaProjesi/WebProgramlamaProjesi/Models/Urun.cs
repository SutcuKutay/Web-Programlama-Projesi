﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProjesi.Models
{
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }

        public string Ad { get; set; }

        public int Fiyat { get; set; }

        public int Stok { get; set; }

        public byte[] rsm { get; set; }

        public string Aciklama { get; set; }

        [ForeignKey("KategoriID")]
        public Kategoriler Kategori { get; set; }
    }
}
