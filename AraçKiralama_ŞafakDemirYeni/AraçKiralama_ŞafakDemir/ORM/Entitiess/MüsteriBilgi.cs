using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraçKiralama_ŞafakDemir.ORM.Entitiess
{
    internal class MüsteriBilgi
    {


        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string AdSoyad{ get; set; }
        [Required, MaxLength(50)]
        public string tc { get; set; }
        [Required, MaxLength(50)]
        public string Tel { get; set; }
        [Required, MaxLength(50)]
        public string Mail { get; set; }
        [Required, MaxLength(50)]
        public string Adres { get; set; }

        

    }
}
