using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraçKiralama_ŞafakDemir.ORM.Entitiess
{
    internal class SözlesmeBilgi
    {
        public int SözlesmeId { get; set; }
        [Required, MaxLength(50)]
        public string AdSoyad { get; set; }
        [Required, MaxLength(50)]
        public string tc { get; set; }
        [Required, MaxLength(50)]
        public string Tel { get; set; }
        [Required, MaxLength(50)]
        public string EhliyetNo { get; set; }
        [Required, MaxLength(50)]
        public string EhliyetTarih { get; set; }
        [Required, MaxLength(50)]
        public string Plaka { get; set; }
        [Required, MaxLength(50)]
        public string Seri { get; set; }
        [Required, MaxLength(50)]
        public string Marka { get; set; }
        [Required, MaxLength(50)]
        public string ModelYıl { get; set; }
        [Required, MaxLength(50)]
        public string Renk { get; set; }
        [Required]
        public int KiraÜcreti { get; set; }
        [Required]
        public int KiraGün { get; set; }
        [Required]
        public int Tutar { get; set; }
        [Required, MaxLength(50)]
        public string cıkısTarih { get; set; }
        [Required, MaxLength(50)]
        public string GirisTarih { get; set; }


    }
}
