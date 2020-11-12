namespace TorbaliBurada.Data.CodeFirst.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ekipyazi_sidart_tor.ArsaGenelOzelikleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArsaGenelOzellik = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.ArsaKonumu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArsaKonum = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.ArsaManzara",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArsaManzarasi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.Bulten",
                c => new
                    {
                        BultenID = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Durumu = c.Int(),
                    })
                .PrimaryKey(t => t.BultenID);
            
            CreateTable(
                "ekipyazi_sidart_tor.Dosyalar",
                c => new
                    {
                        DosyaID = c.Int(nullable: false),
                        KonuID = c.Int(),
                        DosyaAd = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.DosyaID)
                .ForeignKey("ekipyazi_sidart_tor.Konular", t => t.KonuID)
                .Index(t => t.KonuID);
            
            CreateTable(
                "ekipyazi_sidart_tor.Konular",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Baslik = c.String(maxLength: 250),
                        KisaIcerik = c.String(unicode: false, storeType: "text"),
                        UzunIcerik = c.String(unicode: false, storeType: "text"),
                        Resim = c.String(maxLength: 150),
                        Tarih = c.DateTime(),
                        Statu = c.String(maxLength: 10, fixedLength: true),
                        OkunmaSayisi = c.Int(),
                        YorumSayisi = c.Int(),
                        Dosya = c.String(maxLength: 150),
                        Manset = c.Int(),
                        Seo = c.String(maxLength: 150),
                        Description = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.Etiketler",
                c => new
                    {
                        EtiketID = c.Int(nullable: false, identity: true),
                        Etiket = c.String(maxLength: 150),
                        KonuID = c.Int(),
                    })
                .PrimaryKey(t => t.EtiketID)
                .ForeignKey("ekipyazi_sidart_tor.Konular", t => t.KonuID)
                .Index(t => t.KonuID);
            
            CreateTable(
                "ekipyazi_sidart_tor.Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(maxLength: 50),
                        Aciklama = c.String(unicode: false, storeType: "text"),
                        Seo = c.String(maxLength: 150),
                        Keywords = c.String(maxLength: 250),
                        Description = c.String(maxLength: 250),
                        Statu = c.String(maxLength: 10, fixedLength: true),
                        ParentID = c.Int(),
                        Url = c.String(maxLength: 250),
                        Icon = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.Resimler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KonuID = c.Int(),
                        Resim = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.Konular", t => t.KonuID)
                .Index(t => t.KonuID);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakAltyapi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Altyapi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakBanyoSayisi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BanyoSayisi = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanlarEmlakGenel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmlakIlanID = c.Int(),
                        OdaSayisiID = c.Int(),
                        BinaYasiID = c.Int(),
                        BulunduguKatID = c.Int(),
                        KatSayisiID = c.Int(),
                        IsitmaID = c.Int(),
                        BanyoSayisiID = c.Int(),
                        KullanimDurumuID = c.Int(),
                        SiteIcerisindeID = c.Int(),
                        Aidat = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.EmlakBinaYasi", t => t.BinaYasiID)
                .ForeignKey("ekipyazi_sidart_tor.EmlakBulunduguKat", t => t.BulunduguKatID)
                .ForeignKey("ekipyazi_sidart_tor.EmlakIsitmaTuru", t => t.IsitmaID)
                .ForeignKey("ekipyazi_sidart_tor.EmlakKatSayisi", t => t.KatSayisiID)
                .ForeignKey("ekipyazi_sidart_tor.EmlakKullanimDurumu", t => t.KullanimDurumuID)
                .ForeignKey("ekipyazi_sidart_tor.EmlakOdaSayisi", t => t.OdaSayisiID)
                .ForeignKey("ekipyazi_sidart_tor.EmlakSiteIcerisinde", t => t.SiteIcerisindeID)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.EmlakIlanID)
                .ForeignKey("ekipyazi_sidart_tor.EmlakBanyoSayisi", t => t.BanyoSayisiID)
                .Index(t => t.EmlakIlanID)
                .Index(t => t.OdaSayisiID)
                .Index(t => t.BinaYasiID)
                .Index(t => t.BulunduguKatID)
                .Index(t => t.KatSayisiID)
                .Index(t => t.IsitmaID)
                .Index(t => t.BanyoSayisiID)
                .Index(t => t.KullanimDurumuID)
                .Index(t => t.SiteIcerisindeID);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakBinaYasi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BinaYasi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakBulunduguKat",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BulunduguKat = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakIsitmaTuru",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Isitma = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakKatSayisi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KatSayisi = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakKullanimDurumu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullanimDurumu = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakOdaSayisi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OdaSayisi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakSiteIcerisinde",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SiteIcerisinde = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanIlanlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sahibi = c.String(maxLength: 50),
                        CepTelefonu = c.String(maxLength: 11),
                        Baslik = c.String(maxLength: 350),
                        Aciklama = c.String(unicode: false, storeType: "text"),
                        Fiyat = c.Decimal(precision: 18, scale: 2),
                        MetreKare = c.String(maxLength: 10, fixedLength: true),
                        TakasliID = c.Int(),
                        TakasTuru = c.String(maxLength: 50),
                        Ada = c.String(maxLength: 10),
                        Pafta = c.String(maxLength: 10),
                        Parsel = c.String(maxLength: 10),
                        UserName = c.String(maxLength: 50),
                        Private = c.String(maxLength: 10),
                        IletisimTelefonu = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.EmlakTakasli", t => t.TakasliID)
                .Index(t => t.TakasliID);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakKategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(maxLength: 50),
                        ParentID = c.Int(),
                        Icon = c.String(maxLength: 50),
                        Title = c.String(maxLength: 50),
                        Keyword = c.String(maxLength: 50),
                        Description = c.String(maxLength: 50),
                        Aciklama = c.String(unicode: false, storeType: "text"),
                        Durum = c.String(maxLength: 10, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.MusteriList",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Email = c.String(),
                        CepTelefonu = c.String(),
                        EnDusukFiyat = c.Decimal(precision: 18, scale: 2),
                        EnYuksekFiyat = c.Decimal(precision: 18, scale: 2),
                        Statu = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.MusteriListStatu", t => t.Statu)
                .Index(t => t.Statu);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakLocation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LocationName = c.String(maxLength: 50),
                        ParentID = c.Int(),
                        PlakaID = c.Int(),
                        Logo = c.String(maxLength: 50),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.MusteriListStatu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatuDurumu = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakTakasli",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Takasli = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanCepheOzellikler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmlakIlanID = c.Int(),
                        DisOzellik = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.EmlakIlanID)
                .Index(t => t.EmlakIlanID);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanDisOzellikler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmlakIlanID = c.Int(),
                        DisOzellikler = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.EmlakDisOzellikler", t => t.DisOzellikler)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.EmlakIlanID)
                .Index(t => t.EmlakIlanID)
                .Index(t => t.DisOzellikler);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakDisOzellikler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DisOzellik = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanIcOzellikler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmlakIlanID = c.Int(),
                        IcOzellikler = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.EmlakIcOzellikler", t => t.IcOzellikler)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.EmlakIlanID)
                .Index(t => t.EmlakIlanID)
                .Index(t => t.IcOzellikler);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakIcOzellikler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IcOzellik = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanImarDurumu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmlakIlanID = c.Int(),
                        ImarDurumId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.EmlakImarDurumu", t => t.ImarDurumId)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.EmlakIlanID)
                .Index(t => t.EmlakIlanID)
                .Index(t => t.ImarDurumId);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakImarDurumu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmlakDurumu = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanImarTapuDurumu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmlakIlanID = c.Int(),
                        TapuDurumId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.EmlakTapuDurumu", t => t.TapuDurumId)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.EmlakIlanID)
                .Index(t => t.EmlakIlanID)
                .Index(t => t.TapuDurumId);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakTapuDurumu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TapuDurumu = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanKimden",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmlakIlanID = c.Int(),
                        KimdemID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.EmlakKimden", t => t.KimdemID)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.EmlakIlanID)
                .Index(t => t.EmlakIlanID)
                .Index(t => t.KimdemID);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakKimden",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Kimden = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanKonutTipiOzellikler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmlakIlanID = c.Int(),
                        KonutTipiOzellikler = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.EmlakKonutTipi", t => t.KonutTipiOzellikler)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.EmlakIlanID)
                .Index(t => t.EmlakIlanID)
                .Index(t => t.KonutTipiOzellikler);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakKonutTipi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KonutTipi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanKullanimAmaci",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmlakIlanID = c.Int(),
                        KullanimAmaci = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.EmlakKullanimAmaci", t => t.KullanimAmaci)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.EmlakIlanID)
                .Index(t => t.EmlakIlanID)
                .Index(t => t.KullanimAmaci);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakKullanimAmaci",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullanimAmaci = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanManzaraOzellikler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmlakIlanID = c.Int(),
                        ManzaraOzellikler = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.EmlakIlanID)
                .Index(t => t.EmlakIlanID);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanMuhitOzellikler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmlakIlanID = c.Int(),
                        MuhitOzellikler = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.EmlakIlanID)
                .Index(t => t.EmlakIlanID);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanResimler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IlanId = c.Int(),
                        Resim = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.IlanId)
                .Index(t => t.IlanId);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanUlasimOzellikler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmlakIlanID = c.Int(),
                        UlasimOzellikler = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.EmlakIlanID)
                .Index(t => t.EmlakIlanID);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanYapiDurumu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmlakIlanID = c.Int(),
                        YapiDurumuID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ekipyazi_sidart_tor.EmlakYapiDurumu", t => t.YapiDurumuID)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.EmlakIlanID)
                .Index(t => t.EmlakIlanID)
                .Index(t => t.YapiDurumuID);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakYapiDurumu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        YapiDurumu = c.String(maxLength: 20, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakCephe",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cephe = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "ekipyazi_sidart_tor.EmlakDetayBilgisi",
            //    c => new
            //        {
            //            DetayBilgiID = c.Int(nullable: false, identity: true),
            //            DetayBilgi = c.String(maxLength: 50),
            //            KategoriID = c.String(maxLength: 10, fixedLength: true, unicode: false),
            //        })
            //    .PrimaryKey(t => t.DetayBilgiID);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakGenelOzellikler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenelOzellikler = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakIlanTipi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmlakTipi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakManzara",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Manzara = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakMuhit",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Muhit = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakUlasim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ulasim = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.EmlakYapiTipi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        YapiTipi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.ZiyaretciUrl",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ip = c.String(maxLength: 50),
                        RefererUrl = c.String(maxLength: 350),
                        GetUrl = c.String(maxLength: 550),
                        Browser = c.String(maxLength: 50),
                        Tarih = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ekipyazi_sidart_tor.KategoriKonu",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        KonuID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id, t.KonuID })
                .ForeignKey("ekipyazi_sidart_tor.Kategoriler", t => t.Id, cascadeDelete: true)
                .ForeignKey("ekipyazi_sidart_tor.Konular", t => t.KonuID, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.KonuID);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanKategori",
                c => new
                    {
                        KategoriID = c.Int(nullable: false),
                        EmlakIlanID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.KategoriID, t.EmlakIlanID })
                .ForeignKey("ekipyazi_sidart_tor.EmlakKategoriler", t => t.KategoriID, cascadeDelete: true)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.EmlakIlanID, cascadeDelete: true)
                .Index(t => t.KategoriID)
                .Index(t => t.EmlakIlanID);
            
            CreateTable(
                "ekipyazi_sidart_tor.IlanLocation",
                c => new
                    {
                        LocationID = c.Int(nullable: false),
                        EmlakIlanID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LocationID, t.EmlakIlanID })
                .ForeignKey("ekipyazi_sidart_tor.EmlakLocation", t => t.LocationID, cascadeDelete: true)
                .ForeignKey("ekipyazi_sidart_tor.IlanIlanlar", t => t.EmlakIlanID, cascadeDelete: true)
                .Index(t => t.LocationID)
                .Index(t => t.EmlakIlanID);
            
            CreateTable(
                "ekipyazi_sidart_tor.MusteriLocation",
                c => new
                    {
                        LocationID = c.Int(nullable: false),
                        MusteriID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LocationID, t.MusteriID })
                .ForeignKey("ekipyazi_sidart_tor.EmlakLocation", t => t.LocationID, cascadeDelete: true)
                .ForeignKey("ekipyazi_sidart_tor.MusteriList", t => t.MusteriID, cascadeDelete: true)
                .Index(t => t.LocationID)
                .Index(t => t.MusteriID);
            
            CreateTable(
                "ekipyazi_sidart_tor.MusteriKategori",
                c => new
                    {
                        KategoriID = c.Int(nullable: false),
                        MusteriID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.KategoriID, t.MusteriID })
                .ForeignKey("ekipyazi_sidart_tor.EmlakKategoriler", t => t.KategoriID, cascadeDelete: true)
                .ForeignKey("ekipyazi_sidart_tor.MusteriList", t => t.MusteriID, cascadeDelete: true)
                .Index(t => t.KategoriID)
                .Index(t => t.MusteriID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("ekipyazi_sidart_tor.IlanlarEmlakGenel", "BanyoSayisiID", "ekipyazi_sidart_tor.EmlakBanyoSayisi");
            DropForeignKey("ekipyazi_sidart_tor.IlanYapiDurumu", "EmlakIlanID", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanYapiDurumu", "YapiDurumuID", "ekipyazi_sidart_tor.EmlakYapiDurumu");
            DropForeignKey("ekipyazi_sidart_tor.IlanUlasimOzellikler", "EmlakIlanID", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanResimler", "IlanId", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanMuhitOzellikler", "EmlakIlanID", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanManzaraOzellikler", "EmlakIlanID", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanlarEmlakGenel", "EmlakIlanID", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanKullanimAmaci", "EmlakIlanID", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanKullanimAmaci", "KullanimAmaci", "ekipyazi_sidart_tor.EmlakKullanimAmaci");
            DropForeignKey("ekipyazi_sidart_tor.IlanKonutTipiOzellikler", "EmlakIlanID", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanKonutTipiOzellikler", "KonutTipiOzellikler", "ekipyazi_sidart_tor.EmlakKonutTipi");
            DropForeignKey("ekipyazi_sidart_tor.IlanKimden", "EmlakIlanID", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanKimden", "KimdemID", "ekipyazi_sidart_tor.EmlakKimden");
            DropForeignKey("ekipyazi_sidart_tor.IlanImarTapuDurumu", "EmlakIlanID", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanImarTapuDurumu", "TapuDurumId", "ekipyazi_sidart_tor.EmlakTapuDurumu");
            DropForeignKey("ekipyazi_sidart_tor.IlanImarDurumu", "EmlakIlanID", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanImarDurumu", "ImarDurumId", "ekipyazi_sidart_tor.EmlakImarDurumu");
            DropForeignKey("ekipyazi_sidart_tor.IlanIcOzellikler", "EmlakIlanID", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanIcOzellikler", "IcOzellikler", "ekipyazi_sidart_tor.EmlakIcOzellikler");
            DropForeignKey("ekipyazi_sidart_tor.IlanDisOzellikler", "EmlakIlanID", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanDisOzellikler", "DisOzellikler", "ekipyazi_sidart_tor.EmlakDisOzellikler");
            DropForeignKey("ekipyazi_sidart_tor.IlanCepheOzellikler", "EmlakIlanID", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanIlanlar", "TakasliID", "ekipyazi_sidart_tor.EmlakTakasli");
            DropForeignKey("ekipyazi_sidart_tor.MusteriKategori", "MusteriID", "ekipyazi_sidart_tor.MusteriList");
            DropForeignKey("ekipyazi_sidart_tor.MusteriKategori", "KategoriID", "ekipyazi_sidart_tor.EmlakKategoriler");
            DropForeignKey("ekipyazi_sidart_tor.MusteriList", "Statu", "ekipyazi_sidart_tor.MusteriListStatu");
            DropForeignKey("ekipyazi_sidart_tor.MusteriLocation", "MusteriID", "ekipyazi_sidart_tor.MusteriList");
            DropForeignKey("ekipyazi_sidart_tor.MusteriLocation", "LocationID", "ekipyazi_sidart_tor.EmlakLocation");
            DropForeignKey("ekipyazi_sidart_tor.IlanLocation", "EmlakIlanID", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanLocation", "LocationID", "ekipyazi_sidart_tor.EmlakLocation");
            DropForeignKey("ekipyazi_sidart_tor.IlanKategori", "EmlakIlanID", "ekipyazi_sidart_tor.IlanIlanlar");
            DropForeignKey("ekipyazi_sidart_tor.IlanKategori", "KategoriID", "ekipyazi_sidart_tor.EmlakKategoriler");
            DropForeignKey("ekipyazi_sidart_tor.IlanlarEmlakGenel", "SiteIcerisindeID", "ekipyazi_sidart_tor.EmlakSiteIcerisinde");
            DropForeignKey("ekipyazi_sidart_tor.IlanlarEmlakGenel", "OdaSayisiID", "ekipyazi_sidart_tor.EmlakOdaSayisi");
            DropForeignKey("ekipyazi_sidart_tor.IlanlarEmlakGenel", "KullanimDurumuID", "ekipyazi_sidart_tor.EmlakKullanimDurumu");
            DropForeignKey("ekipyazi_sidart_tor.IlanlarEmlakGenel", "KatSayisiID", "ekipyazi_sidart_tor.EmlakKatSayisi");
            DropForeignKey("ekipyazi_sidart_tor.IlanlarEmlakGenel", "IsitmaID", "ekipyazi_sidart_tor.EmlakIsitmaTuru");
            DropForeignKey("ekipyazi_sidart_tor.IlanlarEmlakGenel", "BulunduguKatID", "ekipyazi_sidart_tor.EmlakBulunduguKat");
            DropForeignKey("ekipyazi_sidart_tor.IlanlarEmlakGenel", "BinaYasiID", "ekipyazi_sidart_tor.EmlakBinaYasi");
            DropForeignKey("ekipyazi_sidart_tor.Resimler", "KonuID", "ekipyazi_sidart_tor.Konular");
            DropForeignKey("ekipyazi_sidart_tor.KategoriKonu", "KonuID", "ekipyazi_sidart_tor.Konular");
            DropForeignKey("ekipyazi_sidart_tor.KategoriKonu", "Id", "ekipyazi_sidart_tor.Kategoriler");
            DropForeignKey("ekipyazi_sidart_tor.Etiketler", "KonuID", "ekipyazi_sidart_tor.Konular");
            DropForeignKey("ekipyazi_sidart_tor.Dosyalar", "KonuID", "ekipyazi_sidart_tor.Konular");
            DropIndex("ekipyazi_sidart_tor.MusteriKategori", new[] { "MusteriID" });
            DropIndex("ekipyazi_sidart_tor.MusteriKategori", new[] { "KategoriID" });
            DropIndex("ekipyazi_sidart_tor.MusteriLocation", new[] { "MusteriID" });
            DropIndex("ekipyazi_sidart_tor.MusteriLocation", new[] { "LocationID" });
            DropIndex("ekipyazi_sidart_tor.IlanLocation", new[] { "EmlakIlanID" });
            DropIndex("ekipyazi_sidart_tor.IlanLocation", new[] { "LocationID" });
            DropIndex("ekipyazi_sidart_tor.IlanKategori", new[] { "EmlakIlanID" });
            DropIndex("ekipyazi_sidart_tor.IlanKategori", new[] { "KategoriID" });
            DropIndex("ekipyazi_sidart_tor.KategoriKonu", new[] { "KonuID" });
            DropIndex("ekipyazi_sidart_tor.KategoriKonu", new[] { "Id" });
            DropIndex("ekipyazi_sidart_tor.IlanYapiDurumu", new[] { "YapiDurumuID" });
            DropIndex("ekipyazi_sidart_tor.IlanYapiDurumu", new[] { "EmlakIlanID" });
            DropIndex("ekipyazi_sidart_tor.IlanUlasimOzellikler", new[] { "EmlakIlanID" });
            DropIndex("ekipyazi_sidart_tor.IlanResimler", new[] { "IlanId" });
            DropIndex("ekipyazi_sidart_tor.IlanMuhitOzellikler", new[] { "EmlakIlanID" });
            DropIndex("ekipyazi_sidart_tor.IlanManzaraOzellikler", new[] { "EmlakIlanID" });
            DropIndex("ekipyazi_sidart_tor.IlanKullanimAmaci", new[] { "KullanimAmaci" });
            DropIndex("ekipyazi_sidart_tor.IlanKullanimAmaci", new[] { "EmlakIlanID" });
            DropIndex("ekipyazi_sidart_tor.IlanKonutTipiOzellikler", new[] { "KonutTipiOzellikler" });
            DropIndex("ekipyazi_sidart_tor.IlanKonutTipiOzellikler", new[] { "EmlakIlanID" });
            DropIndex("ekipyazi_sidart_tor.IlanKimden", new[] { "KimdemID" });
            DropIndex("ekipyazi_sidart_tor.IlanKimden", new[] { "EmlakIlanID" });
            DropIndex("ekipyazi_sidart_tor.IlanImarTapuDurumu", new[] { "TapuDurumId" });
            DropIndex("ekipyazi_sidart_tor.IlanImarTapuDurumu", new[] { "EmlakIlanID" });
            DropIndex("ekipyazi_sidart_tor.IlanImarDurumu", new[] { "ImarDurumId" });
            DropIndex("ekipyazi_sidart_tor.IlanImarDurumu", new[] { "EmlakIlanID" });
            DropIndex("ekipyazi_sidart_tor.IlanIcOzellikler", new[] { "IcOzellikler" });
            DropIndex("ekipyazi_sidart_tor.IlanIcOzellikler", new[] { "EmlakIlanID" });
            DropIndex("ekipyazi_sidart_tor.IlanDisOzellikler", new[] { "DisOzellikler" });
            DropIndex("ekipyazi_sidart_tor.IlanDisOzellikler", new[] { "EmlakIlanID" });
            DropIndex("ekipyazi_sidart_tor.IlanCepheOzellikler", new[] { "EmlakIlanID" });
            DropIndex("ekipyazi_sidart_tor.MusteriList", new[] { "Statu" });
            DropIndex("ekipyazi_sidart_tor.IlanIlanlar", new[] { "TakasliID" });
            DropIndex("ekipyazi_sidart_tor.IlanlarEmlakGenel", new[] { "SiteIcerisindeID" });
            DropIndex("ekipyazi_sidart_tor.IlanlarEmlakGenel", new[] { "KullanimDurumuID" });
            DropIndex("ekipyazi_sidart_tor.IlanlarEmlakGenel", new[] { "BanyoSayisiID" });
            DropIndex("ekipyazi_sidart_tor.IlanlarEmlakGenel", new[] { "IsitmaID" });
            DropIndex("ekipyazi_sidart_tor.IlanlarEmlakGenel", new[] { "KatSayisiID" });
            DropIndex("ekipyazi_sidart_tor.IlanlarEmlakGenel", new[] { "BulunduguKatID" });
            DropIndex("ekipyazi_sidart_tor.IlanlarEmlakGenel", new[] { "BinaYasiID" });
            DropIndex("ekipyazi_sidart_tor.IlanlarEmlakGenel", new[] { "OdaSayisiID" });
            DropIndex("ekipyazi_sidart_tor.IlanlarEmlakGenel", new[] { "EmlakIlanID" });
            DropIndex("ekipyazi_sidart_tor.Resimler", new[] { "KonuID" });
            DropIndex("ekipyazi_sidart_tor.Etiketler", new[] { "KonuID" });
            DropIndex("ekipyazi_sidart_tor.Dosyalar", new[] { "KonuID" });
            DropTable("ekipyazi_sidart_tor.MusteriKategori");
            DropTable("ekipyazi_sidart_tor.MusteriLocation");
            DropTable("ekipyazi_sidart_tor.IlanLocation");
            DropTable("ekipyazi_sidart_tor.IlanKategori");
            DropTable("ekipyazi_sidart_tor.KategoriKonu");
            DropTable("ekipyazi_sidart_tor.ZiyaretciUrl");
            DropTable("ekipyazi_sidart_tor.EmlakYapiTipi");
            DropTable("ekipyazi_sidart_tor.EmlakUlasim");
            DropTable("ekipyazi_sidart_tor.EmlakMuhit");
            DropTable("ekipyazi_sidart_tor.EmlakManzara");
            DropTable("ekipyazi_sidart_tor.EmlakIlanTipi");
            DropTable("ekipyazi_sidart_tor.EmlakGenelOzellikler");
           // DropTable("ekipyazi_sidart_tor.EmlakDetayBilgisi");
            DropTable("ekipyazi_sidart_tor.EmlakCephe");
            DropTable("ekipyazi_sidart_tor.EmlakYapiDurumu");
            DropTable("ekipyazi_sidart_tor.IlanYapiDurumu");
            DropTable("ekipyazi_sidart_tor.IlanUlasimOzellikler");
            DropTable("ekipyazi_sidart_tor.IlanResimler");
            DropTable("ekipyazi_sidart_tor.IlanMuhitOzellikler");
            DropTable("ekipyazi_sidart_tor.IlanManzaraOzellikler");
            DropTable("ekipyazi_sidart_tor.EmlakKullanimAmaci");
            DropTable("ekipyazi_sidart_tor.IlanKullanimAmaci");
            DropTable("ekipyazi_sidart_tor.EmlakKonutTipi");
            DropTable("ekipyazi_sidart_tor.IlanKonutTipiOzellikler");
            DropTable("ekipyazi_sidart_tor.EmlakKimden");
            DropTable("ekipyazi_sidart_tor.IlanKimden");
            DropTable("ekipyazi_sidart_tor.EmlakTapuDurumu");
            DropTable("ekipyazi_sidart_tor.IlanImarTapuDurumu");
            DropTable("ekipyazi_sidart_tor.EmlakImarDurumu");
            DropTable("ekipyazi_sidart_tor.IlanImarDurumu");
            DropTable("ekipyazi_sidart_tor.EmlakIcOzellikler");
            DropTable("ekipyazi_sidart_tor.IlanIcOzellikler");
            DropTable("ekipyazi_sidart_tor.EmlakDisOzellikler");
            DropTable("ekipyazi_sidart_tor.IlanDisOzellikler");
            DropTable("ekipyazi_sidart_tor.IlanCepheOzellikler");
            DropTable("ekipyazi_sidart_tor.EmlakTakasli");
            DropTable("ekipyazi_sidart_tor.MusteriListStatu");
            DropTable("ekipyazi_sidart_tor.EmlakLocation");
            DropTable("ekipyazi_sidart_tor.MusteriList");
            DropTable("ekipyazi_sidart_tor.EmlakKategoriler");
            DropTable("ekipyazi_sidart_tor.IlanIlanlar");
            DropTable("ekipyazi_sidart_tor.EmlakSiteIcerisinde");
            DropTable("ekipyazi_sidart_tor.EmlakOdaSayisi");
            DropTable("ekipyazi_sidart_tor.EmlakKullanimDurumu");
            DropTable("ekipyazi_sidart_tor.EmlakKatSayisi");
            DropTable("ekipyazi_sidart_tor.EmlakIsitmaTuru");
            DropTable("ekipyazi_sidart_tor.EmlakBulunduguKat");
            DropTable("ekipyazi_sidart_tor.EmlakBinaYasi");
            DropTable("ekipyazi_sidart_tor.IlanlarEmlakGenel");
            DropTable("ekipyazi_sidart_tor.EmlakBanyoSayisi");
            DropTable("ekipyazi_sidart_tor.EmlakAltyapi");
            DropTable("ekipyazi_sidart_tor.Resimler");
            DropTable("ekipyazi_sidart_tor.Kategoriler");
            DropTable("ekipyazi_sidart_tor.Etiketler");
            DropTable("ekipyazi_sidart_tor.Konular");
            DropTable("ekipyazi_sidart_tor.Dosyalar");
            DropTable("ekipyazi_sidart_tor.Bulten");
            DropTable("ekipyazi_sidart_tor.ArsaManzara");
            DropTable("ekipyazi_sidart_tor.ArsaKonumu");
            DropTable("ekipyazi_sidart_tor.ArsaGenelOzelikleri");
        }
    }
}
