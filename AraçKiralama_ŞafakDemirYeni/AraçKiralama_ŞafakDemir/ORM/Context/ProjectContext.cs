using AraçKiralama_ŞafakDemir.ORM.Entitiess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraçKiralama_ŞafakDemir.ORM.Context
{
    internal class ProjectContext:DbContext
    {

        public ProjectContext():base("Server=DESKTOP-D6TBA31\\SQLEXPRESS;Database=AraçKiralama;Integrated Security=true")
        //public ProjectContext():base("MSSQL")
        {
            //Database.Connection.ConnectionString = "Server=102-26\\SQLDERS;Database=KategoriUrunPaneli;Integrated Security=true";
        }
        public DbSet<MüsteriBilgi> MüsteriBilgis { get; set; }
         public DbSet<AracBilgi> AracBilgis { get; set; }
        public DbSet<SözlesmeBilgi> SözlesmeBilgis { get; set; }
    }
   
}
