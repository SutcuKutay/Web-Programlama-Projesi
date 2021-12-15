using WebProgramlamaProjesi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebProgramlamaProjesi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Urun> Urun{ get; set; }
        
        public DbSet<Kategoriler> Kategoriler{ get; set; }
        
        public DbSet<Kullanici> Kullanici{ get; set; }
        
        public DbSet<Yorum> Yorum{ get; set; }
    }
}
