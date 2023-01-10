using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraçKiralama_ŞafakDemir.ORM.Entitiess
{
    internal class AracBilgi
    {
        
        public int Id { get; set; }
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
        [Required, MaxLength(50)]
        public string Km { get; set; }
        [Required, MaxLength(50)]
        public string Yakıt { get; set; }
        [Required]
        public int KiraÜcreti { get; set; }
        [Required ,MaxLength(50)]
        public string AracDurumu { get; set; }
        



    }
}
