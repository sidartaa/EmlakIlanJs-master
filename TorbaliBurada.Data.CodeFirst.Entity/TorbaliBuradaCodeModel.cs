namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    // Add-Migration Initial -IgnoreChanges
    // Add-Migration InitialCreate 
    //Update-Database
    //update-database -verbose
    //update-database -force
    //Update-Database -TargetMigration:0 -force

    public partial class TorbaliBuradaCodeModel : DbContext
    {
        public TorbaliBuradaCodeModel()
            : base("name = TorbaliBuradaCodeModel")
        {
            // this.Configuration.LazyLoadingEnabled = false;
           // Database.SetInitializer<TorbaliBuradaCodeModel>(new DropCreateDatabaseAlways<TorbaliBuradaCodeModel>());
        }

        public virtual DbSet<ArsaGenelOzelikleri> ArsaGenelOzelikleri { get; set; }
        public virtual DbSet<ArsaKonumu> ArsaKonumu { get; set; }
        public virtual DbSet<ArsaManzara> ArsaManzara { get; set; }
        public virtual DbSet<Bulten> Bulten { get; set; }
        public virtual DbSet<Dosyalar> Dosyalar { get; set; }
        public virtual DbSet<EmlakAltyapi> EmlakAltyapi { get; set; }
        public virtual DbSet<EmlakBanyoSayisi> EmlakBanyoSayisi { get; set; }
        public virtual DbSet<EmlakBinaYasi> EmlakBinaYasi { get; set; }
        public virtual DbSet<EmlakBulunduguKat> EmlakBulunduguKat { get; set; }
        public virtual DbSet<EmlakCephe> EmlakCephe { get; set; }
      
        public virtual DbSet<EmlakDisOzellikler> EmlakDisOzellikler { get; set; }
        public virtual DbSet<EmlakGenelOzellikler> EmlakGenelOzellikler { get; set; }
        public virtual DbSet<EmlakIcOzellikler> EmlakIcOzellikler { get; set; }
        public virtual DbSet<EmlakIlanTipi> EmlakIlanTipi { get; set; }
        public virtual DbSet<EmlakImarDurumu> EmlakImarDurumu { get; set; }
        public virtual DbSet<EmlakIsitmaTuru> EmlakIsitmaTuru { get; set; }
        public virtual DbSet<EmlakKategoriler> EmlakKategoriler { get; set; }
        public virtual DbSet<EmlakKatSayisi> EmlakKatSayisi { get; set; }
        public virtual DbSet<EmlakKimden> EmlakKimden { get; set; }
        public virtual DbSet<EmlakKonutTipi> EmlakKonutTipi { get; set; }
        public virtual DbSet<EmlakKullanimAmaci> EmlakKullanimAmaci { get; set; }
        public virtual DbSet<EmlakKullanimDurumu> EmlakKullanimDurumu { get; set; }
        public virtual DbSet<EmlakLocation> EmlakLocation { get; set; }
        public virtual DbSet<EmlakManzara> EmlakManzara { get; set; }
        public virtual DbSet<EmlakMuhit> EmlakMuhit { get; set; }
        public virtual DbSet<EmlakOdaSayisi> EmlakOdaSayisi { get; set; }
        public virtual DbSet<EmlakSiteIcerisinde> EmlakSiteIcerisinde { get; set; }
        public virtual DbSet<EmlakTakasli> EmlakTakasli { get; set; }
        public virtual DbSet<EmlakTapuDurumu> EmlakTapuDurumu { get; set; }
        public virtual DbSet<EmlakUlasim> EmlakUlasim { get; set; }
        public virtual DbSet<EmlakYapiDurumu> EmlakYapiDurumu { get; set; }
        public virtual DbSet<EmlakYapiTipi> EmlakYapiTipi { get; set; }
        public virtual DbSet<Etiketler> Etiketler { get; set; }
        // public virtual DbSet<IlanAdresler> IlanAdresler { get; set; }
        public virtual DbSet<IlanCepheOzellikler> IlanCepheOzellikler { get; set; }
        public virtual DbSet<IlanDisOzellikler> IlanDisOzellikler { get; set; }
        public virtual DbSet<IlanIcOzellikler> IlanIcOzellikler { get; set; }
        public virtual DbSet<IlanIlanlar> IlanIlanlar { get; set; }
        public virtual DbSet<IlanKimden> IlanKimden { get; set; }
        public virtual DbSet<IlanKonutTipiOzellikler> IlanKonutTipiOzellikler { get; set; }
        public virtual DbSet<IlanKullanimAmaci> IlanKullanimAmaci { get; set; }
        public virtual DbSet<IlanlarEmlakGenel> IlanlarEmlakGenel { get; set; }
        public virtual DbSet<IlanManzaraOzellikler> IlanManzaraOzellikler { get; set; }
        public virtual DbSet<IlanMuhitOzellikler> IlanMuhitOzellikler { get; set; }
        public virtual DbSet<IlanUlasimOzellikler> IlanUlasimOzellikler { get; set; }
        public virtual DbSet<IlanYapiDurumu> IlanYapiDurumu { get; set; }
        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<Konular> Konular { get; set; }
        public virtual DbSet<Resimler> Resimler { get; set; }
        public virtual DbSet<ZiyaretciUrl> ZiyaretciUrl { get; set; }
        public virtual DbSet<IlanResimler> IlanResimler { get; set; }
        public virtual DbSet<IlanImarDurumu> IlanImarDurumu { get; set; }
        public virtual DbSet<MusteriList> MusteriList { get; set; }
        public virtual DbSet<MusteriListStatu> MusteriListStatu { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         // Database.SetInitializer<TorbaliBuradaCodeModel>(new DropCreateDatabaseIfModelChanges<TorbaliBuradaCodeModel>());

            modelBuilder.Entity<EmlakBanyoSayisi>()
                .Property(e => e.BanyoSayisi)
                .IsFixedLength();

            modelBuilder.Entity<EmlakBanyoSayisi>()
                .HasMany(e => e.IlanlarEmlakGenel)
                .WithOptional(e => e.EmlakBanyoSayisi)
                .HasForeignKey(e => e.BanyoSayisiID);

            modelBuilder.Entity<EmlakBinaYasi>()
                .HasMany(e => e.IlanlarEmlakGenel)
                .WithOptional(e => e.EmlakBinaYasi)
                .HasForeignKey(e => e.BinaYasiID);

            modelBuilder.Entity<EmlakBulunduguKat>()
                .HasMany(e => e.IlanlarEmlakGenel)
                .WithOptional(e => e.EmlakBulunduguKat)
                .HasForeignKey(e => e.BulunduguKatID);

         

            modelBuilder.Entity<EmlakIsitmaTuru>()
                .HasMany(e => e.IlanlarEmlakGenel)
                .WithOptional(e => e.EmlakIsitmaTuru)
                .HasForeignKey(e => e.IsitmaID);

            modelBuilder.Entity<EmlakKategoriler>()
                .Property(e => e.Aciklama)
                .IsUnicode(false);

            modelBuilder.Entity<EmlakKategoriler>()
                .Property(e => e.Durum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmlakKategoriler>()
                .HasMany(e => e.IlanIlanlar)
                .WithMany(e => e.EmlakKategoriler)
                .Map(m => m.ToTable("IlanKategori", "ekipyazi_sidart_tor").MapLeftKey("KategoriID").MapRightKey("EmlakIlanID"));

            modelBuilder.Entity<IlanIlanlar>()
                           .HasMany(e => e.EmlakKategoriler)
                           .WithMany(e => e.IlanIlanlar)
                           .Map(m => m.ToTable("IlanKategori", "ekipyazi_sidart_tor").MapLeftKey("EmlakIlanID").MapRightKey("KategoriID"));

           // Musteri List &Kategoriler
            modelBuilder.Entity<EmlakKategoriler>()
                .HasMany(e => e.MusteriList)
                .WithMany(e => e.EmlakKategoriler)
                .Map(m => m.ToTable("MusteriKategori", "ekipyazi_sidart_tor").MapLeftKey("KategoriID").MapRightKey("MusteriID"));

            modelBuilder.Entity<MusteriList>()
                           .HasMany(e => e.EmlakKategoriler)
                           .WithMany(e => e.MusteriList)
                           .Map(m => m.ToTable("MusteriKategori", "ekipyazi_sidart_tor").MapLeftKey("MusteriID").MapRightKey("KategoriID"));
           // Musteri List Location
            modelBuilder.Entity<EmlakLocation>()
               .HasMany(e => e.MusteriList)
               .WithMany(e => e.EmlakLocation)
               .Map(m => m.ToTable("MusteriLocation", "ekipyazi_sidart_tor").MapLeftKey("LocationID").MapRightKey("MusteriID"));

            modelBuilder.Entity<MusteriList>()
                           .HasMany(e => e.EmlakLocation)
                           .WithMany(e => e.MusteriList)
                           .Map(m => m.ToTable("MusteriLocation", "ekipyazi_sidart_tor").MapLeftKey("MusteriID").MapRightKey("LocationID"));
            //Müþteri Takas Durumu
            modelBuilder.Entity<MusteriListStatu>()
               .HasMany(e => e.MusteriList)
               .WithOptional(e => e.MusteriListStatu)
               .HasForeignKey(e => e.Statu);

            modelBuilder.Entity<EmlakKatSayisi>()
                .Property(e => e.KatSayisi)
                .IsFixedLength();

            modelBuilder.Entity<EmlakKatSayisi>()
                .HasMany(e => e.IlanlarEmlakGenel)
                .WithOptional(e => e.EmlakKatSayisi)
                .HasForeignKey(e => e.KatSayisiID);

            modelBuilder.Entity<EmlakKimden>()
                .HasMany(e => e.IlanKimden)
                .WithOptional(e => e.EmlakKimden)
                .HasForeignKey(e => e.KimdemID);

            modelBuilder.Entity<EmlakKullanimDurumu>()
                .HasMany(e => e.IlanlarEmlakGenel)
                .WithOptional(e => e.EmlakKullanimDurumu)
                .HasForeignKey(e => e.KullanimDurumuID);

            modelBuilder.Entity<EmlakManzara>()
                  .Property(e => e.Manzara)
                  .IsFixedLength();

            modelBuilder.Entity<EmlakIcOzellikler>()
               .HasMany(e => e.IlanIcOzellikler)
               .WithOptional(e => e.EmlakIcOzellikler)
               .HasForeignKey(e => e.IcOzellikler);

            modelBuilder.Entity<EmlakDisOzellikler>()
                .HasMany(e => e.IlanDisOzellikler)
                .WithOptional(e => e.EmlakDisOzellikler)
                .HasForeignKey(e => e.DisOzellikler);

            modelBuilder.Entity<EmlakKonutTipi>()
               .HasMany(e => e.IlanKonutTipiOzellikler)
               .WithOptional(e => e.EmlakKonutTipi)
               .HasForeignKey(e => e.KonutTipiOzellikler);

            modelBuilder.Entity<EmlakOdaSayisi>()
                .HasMany(e => e.IlanlarEmlakGenel)
                .WithOptional(e => e.EmlakOdaSayisi)
                .HasForeignKey(e => e.OdaSayisiID);

            modelBuilder.Entity<EmlakKullanimAmaci>()
                .HasMany(e => e.IlanKullanimAmaci)
                .WithOptional(e => e.EmlakKullanimAmaci)
                .HasForeignKey(e => e.KullanimAmaci);

            modelBuilder.Entity<EmlakSiteIcerisinde>()
                .HasMany(e => e.IlanlarEmlakGenel)
                .WithOptional(e => e.EmlakSiteIcerisinde)
                .HasForeignKey(e => e.SiteIcerisindeID);

            modelBuilder.Entity<EmlakTakasli>()
                .Property(e => e.Takasli)
                .IsFixedLength();

            modelBuilder.Entity<EmlakTakasli>()
                .HasMany(e => e.IlanIlanlar)
                .WithOptional(e => e.EmlakTakasli)
                .HasForeignKey(e => e.TakasliID);

            modelBuilder.Entity<EmlakYapiDurumu>()
                .Property(e => e.YapiDurumu)
                .IsFixedLength();

            modelBuilder.Entity<EmlakYapiDurumu>()
                .HasMany(e => e.IlanYapiDurumu)
                .WithOptional(e => e.EmlakYapiDurumu)
                .HasForeignKey(e => e.YapiDurumuID);

            modelBuilder.Entity<IlanIlanlar>()
                .Property(e => e.Aciklama)
                .IsUnicode(false);

            modelBuilder.Entity<IlanIlanlar>()
                .Property(e => e.MetreKare)
                .IsFixedLength();

            //modelBuilder.Entity<IlanIlanlar>()
            //    .HasMany(e => e.IlanAdresler)
            //    .WithOptional(e => e.IlanIlanlar)
            //    .HasForeignKey(e => e.EmlakIlanID);

            modelBuilder.Entity<IlanIlanlar>()
                .HasMany(e => e.IlanCepheOzellikler)
                .WithOptional(e => e.IlanIlanlar)
                .HasForeignKey(e => e.EmlakIlanID);

            modelBuilder.Entity<IlanIlanlar>()
                .HasMany(e => e.IlanDisOzellikler)
                .WithOptional(e => e.IlanIlanlar)
                .HasForeignKey(e => e.EmlakIlanID);

            modelBuilder.Entity<IlanIlanlar>()
                .HasMany(e => e.IlanIcOzellikler)
                .WithOptional(e => e.IlanIlanlar)
                .HasForeignKey(e => e.EmlakIlanID);

            modelBuilder.Entity<IlanIlanlar>()
                .HasMany(e => e.IlanKimden)
                .WithOptional(e => e.IlanIlanlar)
                .HasForeignKey(e => e.EmlakIlanID);

            modelBuilder.Entity<IlanIlanlar>()
                .HasMany(e => e.IlanKonutTipiOzellikler)
                .WithOptional(e => e.IlanIlanlar)
                .HasForeignKey(e => e.EmlakIlanID);

            modelBuilder.Entity<IlanIlanlar>()
                .HasMany(e => e.IlanKullanimAmaci)
                .WithOptional(e => e.IlanIlanlar)
                .HasForeignKey(e => e.EmlakIlanID);

            modelBuilder.Entity<IlanIlanlar>()
                .HasMany(e => e.IlanlarEmlakGenel)
                .WithOptional(e => e.IlanIlanlar)
                .HasForeignKey(e => e.EmlakIlanID);

            modelBuilder.Entity<IlanIlanlar>()
                .HasMany(e => e.IlanManzaraOzellikler)
                .WithOptional(e => e.IlanIlanlar)
                .HasForeignKey(e => e.EmlakIlanID);

            modelBuilder.Entity<IlanIlanlar>()
                .HasMany(e => e.IlanMuhitOzellikler)
                .WithOptional(e => e.IlanIlanlar)
                .HasForeignKey(e => e.EmlakIlanID);

            modelBuilder.Entity<IlanIlanlar>()
                .HasMany(e => e.IlanUlasimOzellikler)
                .WithOptional(e => e.IlanIlanlar)
                .HasForeignKey(e => e.EmlakIlanID);

            modelBuilder.Entity<IlanIlanlar>()
                .HasMany(e => e.IlanYapiDurumu)
                .WithOptional(e => e.IlanIlanlar)
                .HasForeignKey(e => e.EmlakIlanID);

            modelBuilder.Entity<IlanMuhitOzellikler>()
                .Property(e => e.MuhitOzellikler)
                .IsFixedLength();

            modelBuilder.Entity<Kategoriler>()
                .Property(e => e.Aciklama)
                .IsUnicode(false);

            modelBuilder.Entity<Kategoriler>()
                .Property(e => e.Statu)
                .IsFixedLength();

            modelBuilder.Entity<Kategoriler>()
                .HasMany(e => e.Konular)
                .WithMany(e => e.Kategoriler)
                .Map(m => m.ToTable("KategoriKonu", "ekipyazi_sidart_tor").MapLeftKey("Id").MapRightKey("KonuID"));

            modelBuilder.Entity<Konular>()
                .Property(e => e.KisaIcerik)
                .IsUnicode(false);

            modelBuilder.Entity<Konular>()
                .Property(e => e.UzunIcerik)
                .IsUnicode(false);

            modelBuilder.Entity<Konular>()
                .Property(e => e.Statu)
                .IsFixedLength();

            modelBuilder.Entity<Konular>()
                .HasMany(e => e.Dosyalar)
                .WithOptional(e => e.Konular)
                .HasForeignKey(e => e.KonuID);

            modelBuilder.Entity<Konular>()
                .HasMany(e => e.Etiketler)
                .WithOptional(e => e.Konular)
                .HasForeignKey(e => e.KonuID);

            modelBuilder.Entity<Konular>()
                .HasMany(e => e.Resimler)
                .WithOptional(e => e.Konular)
                .HasForeignKey(e => e.KonuID);

            modelBuilder.Entity<IlanIlanlar>()
                .HasMany(e => e.IlanResimler)
                .WithOptional(e => e.IlanIlanlar)
                .HasForeignKey(e => e.IlanId);

            modelBuilder.Entity<IlanIlanlar>()
               .HasMany(e => e.IlanImarTapuDurumu)
               .WithOptional(e => e.IlanIlanlar)
               .HasForeignKey(e => e.EmlakIlanID);

            modelBuilder.Entity<IlanIlanlar>()
              .HasMany(e => e.IlanImarDurumu)
              .WithOptional(e => e.IlanIlanlar)
              .HasForeignKey(e => e.EmlakIlanID);

            modelBuilder.Entity<EmlakImarDurumu>()
              .HasMany(e => e.IlanImarDurumu)
              .WithOptional(e => e.EmlakImarDurumu)
              .HasForeignKey(e => e.ImarDurumId);

            modelBuilder.Entity<EmlakTapuDurumu>()
              .HasMany(e => e.IlanImarTapuDurumu)
              .WithOptional(e => e.EmlakTapuDurumu)
              .HasForeignKey(e => e.TapuDurumId);

            //modelBuilder.Entity<EmlakLocation>()
            //    .HasMany(e => e.IlanAdresler)
            //    .WithOptional(e => e.EmlakLocation)
            //    .HasForeignKey(e => e.LocationID);
            modelBuilder.Entity<IlanIlanlar>()
                         .HasMany(e => e.EmlakLocation)
                         .WithMany(e => e.IlanIlanlar)
                         .Map(m => m.ToTable("IlanLocation", "ekipyazi_sidart_tor").MapLeftKey("EmlakIlanID").MapRightKey("LocationID"));
            modelBuilder.Entity<EmlakLocation>()
                .HasMany(e => e.IlanIlanlar)
                .WithMany(e => e.EmlakLocation)
                .Map(m => m.ToTable("IlanLocation", "ekipyazi_sidart_tor").MapLeftKey("LocationID").MapRightKey("EmlakIlanID"));
        }
    }
}
