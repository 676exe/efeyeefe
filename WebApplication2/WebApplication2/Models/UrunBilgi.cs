using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UrunBilgi
    {
        [Key]
        public int barkod { get; set; }
        public string adi { get; set; }
        public int birimGrami { get; set; }
        public int birimFiyati { get; set; }
        public int adet { get; set; }
        public int resim { get; set; }
        public int fire { get; set; }
        public int koliAdeti { get; set; }
        public int toplamFiyat { get; set; }
        public int toplamGram { get; set; }
    }

    public class UrunVt: DbContext
    {
        public DbSet<UrunBilgi> UrunDb { get; set; }
    }
}