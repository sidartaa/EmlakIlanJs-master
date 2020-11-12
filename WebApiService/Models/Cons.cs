using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiService.Models
{
    public static class Cons
    {
        public static class Input
        {
            public static string text = "text";
            public static string mail = "mail";
            public static string tel = "tel";
            public static string radio = "radio";
        }
        public static class IlanBaslik
        {
            public const string Title = "İlan Başlığı";
            public const string Baslik = "Baslik";
            public const string PlaceHolder = "İlan başlığı giriniz.";
      }
        public static class ArsaKonum
        {
            public const string ArsaKonumID = "ArsaKonumID";
            public const string Altyapi = "ArsaManzarasi";
            public const string Title = "Arsanın Manzarası";
        }
        public static class ArsaManzara
        {
            public const string ArsaManzaraID = "ArsaManzaraID";
            public const string Altyapi = "ArsaKonum";
            public const string Title = "Arsanın Konumu";
        }
        public static class ArsaOzellikler
        {
            public const string ArsaGenelOzellikID = "ArsaGenelOzellikID";
            public const string ArsaGenelOzellik = "ArsaGenelOzellik";
            public const string Title = "Arsanın Genel Özellikleri";
        }
        public static class EmlAltyapi
        {
            public const string AltyapiID = "AltyapiID";
            public const string Altyapi = "Altyapi";
            public const string Title = "Alt Yapı";
        }
        public static class EmlBanyoSayisi
        {
            public const string BanyoSayisiID = "BanyoSayisiID";
            public const string BanyoSayisi = "BanyoSayisi";
            public const string Title = "Banyo Sayısı";
        }
        public static class EmlBinaYasi
        {
            public const string BinaYasiID = "BinaYasiID";
            public const string BinaYasi = "BinaYasi";
            public const string Title = "Bina Yaşı";
        }
        public static class EmlBulunduguKat
        {
            public const string BulunduguKatID = "BulunduguKatID";
            public const string BulunduguKat = "BulunduguKat";
            public const string Title = "Bulunduğu kat";
        }
        public static class EmlCephe
        {
            public const string CepheID = "CepheID";
            public const string Cephe = "Cephe";
            public const string Title = "Bina Cep No";
        }
        public static class EmlDisOzellikler
        {
            public const string DisOzellikID = "DisOzellikID";
            public const string DisOzellik = "DisOzellik";
            public const string Title = "Dış Çzellikler";
        }
        public static class EmlGenelOzellikler
        {
            public const string GenelOZelliklerID = "GenelOZelliklerID";
            public const string GenelOzellikler = "GenelOzellikler";
            public const string Title = "Genel Özellikler";
        }
        public static class EmlIlanTipi
        {
            public const string EmlakTipID = "EmlakTipi";
            public const string EmlakTipi = "EmlakTipi";
            public const string Title = "Emlak Tipi";
        }
        public static class EmlImarDurumu
        {
            public const string EmlakDurumuID = "EmlakDurumuID";
            public const string EmlakDurumu = "EmlakDurumu";
            public const string Title = "Emlak Durumu";
        }
        public static class EmlIsitmaTuru
        {
            public const string IsitmaID = "IsitmaID";
            public const string Isitma = "Isitma";
            public const string Title = "Isıtma Türü";
        }
        public static class EmlKategoriler
        {
            public const string KategoriID = "KategoriID";
            public const string KategoriAd = "KategoriAd";
            public const string ParentID = "ParentID";
            public const string Icon = "Icon";
            public const string Title = "Title";
            public const string Keyword = "Keyword";
            public const string Description = "Description";
            public const string Aciklama = "Aciklama";
            public const string Durum = "Durum";
            public const string TitleKat = "Kategoriler";
        }
        public static class EmlKatSayisi
        {
            public const string KatSayisiID = "KatSayisiID";
            public const string KatSayisi = "KatSayisi";
            public const string Title = "Kat Sayısı";
        }
        public static class EmlKimden
        {
            public const string KimdenID = "KimdenID";
            public const string Kimden = "Kimden";
            public const string Title = "İlan Kimden";
        }
        public static class EmlKonutTipi
        {
            public const string KonutTipiID = "KonutTipiID";
            public const string KonutTipi = "KonutTipi";
            public const string Title = "Konut Tipi";
        }
        public static class EmlKullanimAmaci
        {
            public const string KullanimAmaciID = "KullanimAmaciID";
            public const string KullanimAmaci = "KullanimAmaci";
            public const string Title = "Kullanım Amacı";
        }
        public static class EmlKullanimDurumu
        {
            public const string KullanimDurumuID = "KullanimDurumuID";
            public const string KullanimDurumu = "KullanimDurumu";
            public const string Title = "Kullanım Durumu";
        }
        public static class EmlLocation
        {
            public const string LocationID = "LocationID";
            public const string LocationName = "LocationName";
            public const string ParentID = "ParentID";
            public const string PlakaID = "PlakaID";
            public const string Logo = "Logo";
            public const string Aciklama = "Aciklama";
            public const string Title = "İlan Lokasyon";
        }
        public static class EmlManzara
        {
            public const string ManzaraID = "ManzaraID";
            public const string Manzara = "Manzara";
            public const string Title = "Manzara";
        }
        public static class EmlMuhit
        {
            public const string MuhitID = "MuhitID";
            public const string Muhit = "Muhit";
            public const string Title = "Muhit";
        }
        public static class EmlOdaSayisi
        {
            public const string OdaSayisiID = "OdaSayisiID";
            public const string OdaSayisi = "OdaSayisi";
            public const string Title = "Oda Sayısı";
        }
        public static class EmlSiteIcerisinde
        {
            public const string SiteIcerisindeID = "SiteIcerisindeID";
            public const string SiteIcerisinde = "SiteIcerisinde";
            public const string Title = "Site İçerisinde";
        }
        public static class EmlTakasli
        {
            public const string TakasliID = "TakasliID";
            public const string Takasli = "Takasli";
            public const string Title = "Talaslı";
        }
        public static class EmlTapuDurumu
        {
            public const string TapuDurumuID = "TapuDurumuID";
            public const string TapuDurumu = "TapuDurumu";
            public const string Title = "Tapu Durumu";
        }
        public static class EmlUlasim
        {
            public const string UlasimID = "UlasimID";
            public const string Ulasim = "Ulasim";
            public const string Title = "Ulaşım";
        }
        public static class EmlYapiDurumu
        {
            public const string YapiDurumuID = "YapiDurumuID";
            public const string YapiDurumu = "YapiDurumu";
            public const string Title = "Yapı Durumu";
        }
        public static class EmlYapiTipi
        {
            public const string YapiTipiID = "YapiTipiID";
            public const string YapiTipi = "YapiTipi";
            public const string Title = "Yapı Tipi";
        }
        public static class EmlIcOzellikler
        {
            public const string IcOzellikID = "IcOzellikID";
            public const string IcOzellik = "IcOzellik";
            public const string Title = "İç Özellikler";
        }
        public static class FormButtonString
        {
            public const string Kaydet = "Kaydet";
            public const string Sil = "Sil";
            public const string Duzenle = "Düzenle";
        }

    }
}