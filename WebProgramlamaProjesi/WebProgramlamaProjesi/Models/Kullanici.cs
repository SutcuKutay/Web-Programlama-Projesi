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
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string GercekAd { get; set; }
        [Required]
        public string GercekSoyad { get; set; }
        public string? KullaniciAdres { get; set; }
        public string? TelefonNo { get; set; }
        [Required]
        [MinLength(3)]
        public string Sifre { get; set; }
    }
}
