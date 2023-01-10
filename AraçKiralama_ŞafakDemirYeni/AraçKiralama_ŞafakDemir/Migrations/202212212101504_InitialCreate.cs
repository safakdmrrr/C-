namespace AraçKiralama_ŞafakDemir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AracBilgis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Plaka = c.String(nullable: false, maxLength: 50),
                        Marka = c.String(nullable: false, maxLength: 50),
                        ModelYıl = c.String(nullable: false, maxLength: 50),
                        Renk = c.String(nullable: false, maxLength: 50),
                        Km = c.String(nullable: false, maxLength: 50),
                        Yakıt = c.String(nullable: false, maxLength: 50),
                        KiraÜcreti = c.String(nullable: false, maxLength: 50),
                        AracDurumu = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MüsteriBilgi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(nullable: false, maxLength: 50),
                        Tel = c.String(nullable: false, maxLength: 50),
                        Mail = c.String(nullable: false, maxLength: 50),
                        Adres = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MüsteriBilgi");
            DropTable("dbo.AracBilgis");
        }
    }
}
