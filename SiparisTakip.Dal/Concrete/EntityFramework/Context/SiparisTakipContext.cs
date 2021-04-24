using SiparisTakip.Entity.Model;
using System.Data.Entity;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Context

{
    public partial class SiparisTakipContext : DbContext
    {
        public SiparisTakipContext()
            : base("name=SiparisTakipContext")
        {
        }

        public virtual DbSet<Aksesuar> Aksesuars { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Ayarlar> Ayarlars { get; set; }
        public virtual DbSet<BankaHesap> BankaHesaps { get; set; }
        public virtual DbSet<BankaHesapHareket> BankaHesapHarekets { get; set; }
        public virtual DbSet<Cari> Caris { get; set; }
        public virtual DbSet<CariHareket> CariHarekets { get; set; }
        public virtual DbSet<CariStokFiyat> CariStokFiyats { get; set; }
        public virtual DbSet<Fatura> Faturas { get; set; }
        public virtual DbSet<FaturaDetay> FaturaDetays { get; set; }
        public virtual DbSet<Il> Ils { get; set; }
        public virtual DbSet<Ilce> Ilces { get; set; }
        public virtual DbSet<Isyeri> Isyeris { get; set; }
        public virtual DbSet<Kasa> Kasas { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<KullaniciYetki> KullaniciYetkis { get; set; }
        public virtual DbSet<Maa> Maas { get; set; }
        public virtual DbSet<MaasHareket> MaasHarekets { get; set; }
        public virtual DbSet<Marka> Markas { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Personel> Personels { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<RutHareketPlani> RutHareketPlanis { get; set; }
        public virtual DbSet<Sati> Satis { get; set; }
        public virtual DbSet<SatisDetay> SatisDetays { get; set; }
        public virtual DbSet<Sektor> Sektors { get; set; }
        public virtual DbSet<Stok> Stoks { get; set; }
        public virtual DbSet<StokDepo> StokDepoes { get; set; }
        public virtual DbSet<StokETicaret> StokETicarets { get; set; }
        public virtual DbSet<StokHareket> StokHarekets { get; set; }
        public virtual DbSet<StokResim> StokResims { get; set; }
        public virtual DbSet<StokSayim> StokSayims { get; set; }
        public virtual DbSet<StokSayimDetay> StokSayimDetays { get; set; }
        public virtual DbSet<StokVaryant> StokVaryants { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tanim> Tanims { get; set; }
        public virtual DbSet<TanimGrup> TanimGrups { get; set; }
        public virtual DbSet<TeknikServi> TeknikServis { get; set; }
        public virtual DbSet<Ulke> Ulkes { get; set; }
        public virtual DbSet<Yetki> Yetkis { get; set; }
        public virtual DbSet<Sabit> Sabits { get; set; }
        public virtual DbSet<vw_BankaHesap> vw_BankaHesap { get; set; }
        public virtual DbSet<vw_BankaHesapHareket> vw_BankaHesapHareket { get; set; }
        public virtual DbSet<vw_CariBakiye> vw_CariBakiye { get; set; }
        public virtual DbSet<vw_CariHareket> vw_CariHareket { get; set; }
        public virtual DbSet<vw_Fatura> vw_Fatura { get; set; }
        public virtual DbSet<vw_FaturaDetay> vw_FaturaDetay { get; set; }
        public virtual DbSet<vw_Kullanici> vw_Kullanici { get; set; }
        public virtual DbSet<vw_SatisDetayListesi> vw_SatisDetayListesi { get; set; }
        public virtual DbSet<vw_SatisListesi> vw_SatisListesi { get; set; }
        public virtual DbSet<vw_StokDetayliHesapEkstresi> vw_StokDetayliHesapEkstresi { get; set; }
        public virtual DbSet<vw_StokHareketListesi> vw_StokHareketListesi { get; set; }
        public virtual DbSet<vw_StokListesi> vw_StokListesi { get; set; }
        public virtual DbSet<vw_StokSayim> vw_StokSayim { get; set; }
        public virtual DbSet<vw_StokVaryantListesi> vw_StokVaryantListesi { get; set; }
        public virtual DbSet<vw_TeknikServis> vw_TeknikServis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ayarlar>()
                .Property(e => e.IrsaliyeSeri)
                .IsUnicode(false);

            modelBuilder.Entity<Ayarlar>()
                .Property(e => e.FaturaSeri)
                .IsUnicode(false);

            modelBuilder.Entity<Cari>()
                .Property(e => e.TCKimlikNo)
                .IsUnicode(false);

            modelBuilder.Entity<Cari>()
                .HasMany(e => e.CariHarekets)
                .WithRequired(e => e.Cari)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cari>()
                .HasMany(e => e.CariStokFiyats)
                .WithRequired(e => e.Cari)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CariStokFiyat>()
                .Property(e => e.MaccAdress)
                .IsUnicode(false);

            modelBuilder.Entity<Fatura>()
                .Property(e => e.IrsaliyeSeri)
                .IsUnicode(false);

            modelBuilder.Entity<Fatura>()
                .Property(e => e.FaturaSeri)
                .IsUnicode(false);

            modelBuilder.Entity<FaturaDetay>()
                .Property(e => e.BirimFiyati)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FaturaDetay>()
                .Property(e => e.DovizBirimFiyati)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.IsyeriAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.VergiDairesi)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.VergiNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.YetkiliAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.YetkiliSoyadi)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.TelNo)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.FaksNo)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.CepTelNo)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.Adres)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.Ili)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.Ilcesi)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.WebAdresi)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.TicaretSicilNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Isyeri>()
                .HasOptional(e => e.Ayarlar)
                .WithRequired(e => e.Isyeri);

            modelBuilder.Entity<Isyeri>()
                .HasMany(e => e.CariStokFiyats)
                .WithRequired(e => e.Isyeri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Isyeri>()
                .HasMany(e => e.Kasas)
                .WithRequired(e => e.Isyeri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Isyeri>()
                .HasMany(e => e.StokSayims)
                .WithRequired(e => e.Isyeri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Isyeri>()
                .HasMany(e => e.StokVaryants)
                .WithRequired(e => e.Isyeri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.CepTelNo)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.TCKimlikNo)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.CariStokFiyats)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.Faturas)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.Satis)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marka>()
                .Property(e => e.MarkaAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Model>()
                .Property(e => e.ModelAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Personel>()
                .HasMany(e => e.MaasHarekets)
                .WithRequired(e => e.Personel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Personel>()
                .HasMany(e => e.RutHareketPlanis)
                .WithOptional(e => e.Personel)
                .HasForeignKey(e => e.PlasiyerID);

            modelBuilder.Entity<RutHareketPlani>()
                .Property(e => e.Gun)
                .IsUnicode(false);

            modelBuilder.Entity<RutHareketPlani>()
                .Property(e => e.MaccAdress)
                .IsUnicode(false);

            modelBuilder.Entity<Sati>()
                .Property(e => e.IskontoOrani)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Sati>()
                .HasMany(e => e.BankaHesapHarekets)
                .WithOptional(e => e.Sati)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Sati>()
                .HasMany(e => e.CariHarekets)
                .WithOptional(e => e.Sati)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Sati>()
                .HasMany(e => e.Faturas)
                .WithOptional(e => e.Sati)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Sati>()
                .HasMany(e => e.Kasas)
                .WithOptional(e => e.Sati)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SatisDetay>()
                .Property(e => e.Miktari)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SatisDetay>()
                .Property(e => e.IskontoOrani)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SatisDetay>()
                .HasMany(e => e.StokHarekets)
                .WithOptional(e => e.SatisDetay)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Sektor>()
                .Property(e => e.SektorAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.CariStokFiyats)
                .WithRequired(e => e.Stok)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.SatisDetays)
                .WithRequired(e => e.Stok)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.StokDepoes)
                .WithOptional(e => e.Stok)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.StokETicarets)
                .WithRequired(e => e.Stok)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.StokHarekets)
                .WithRequired(e => e.Stok)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.StokResims)
                .WithRequired(e => e.Stok)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.StokSayimDetays)
                .WithRequired(e => e.Stok)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.StokVaryants)
                .WithRequired(e => e.Stok)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StokDepo>()
                .Property(e => e.KoridorNo)
                .IsUnicode(false);

            modelBuilder.Entity<StokDepo>()
                .Property(e => e.RafNo)
                .IsUnicode(false);

            modelBuilder.Entity<StokHareket>()
                .Property(e => e.Miktar)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StokResim>()
                .Property(e => e.MaccAdress)
                .IsUnicode(false);

            modelBuilder.Entity<StokVaryant>()
                .HasMany(e => e.StokDepoes)
                .WithOptional(e => e.StokVaryant)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Tanim>()
                .HasMany(e => e.BankaHesaps)
                .WithOptional(e => e.Tanim)
                .HasForeignKey(e => e.ParaTuruID);

            modelBuilder.Entity<Tanim>()
                .HasMany(e => e.BankaHesaps1)
                .WithOptional(e => e.Tanim1)
                .HasForeignKey(e => e.BankaID);

            modelBuilder.Entity<Tanim>()
                .HasMany(e => e.StokDepoes)
                .WithOptional(e => e.Tanim)
                .HasForeignKey(e => e.DepoID);

            modelBuilder.Entity<Tanim>()
                .HasMany(e => e.StokSayimDetays)
                .WithRequired(e => e.Tanim)
                .HasForeignKey(e => e.DepoID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TanimGrup>()
                .HasMany(e => e.Tanims)
                .WithRequired(e => e.TanimGrup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<vw_BankaHesap>()
                .Property(e => e.Bakiye)
                .HasPrecision(38, 2);

            modelBuilder.Entity<vw_BankaHesapHareket>()
                .Property(e => e.IsyeriAdi)
                .IsUnicode(false);

            modelBuilder.Entity<vw_CariBakiye>()
                .Property(e => e.Alacak)
                .HasPrecision(38, 2);

            modelBuilder.Entity<vw_CariBakiye>()
                .Property(e => e.Borc)
                .HasPrecision(38, 2);

            modelBuilder.Entity<vw_CariBakiye>()
                .Property(e => e.Bakiye)
                .HasPrecision(38, 2);

            modelBuilder.Entity<vw_CariBakiye>()
                .Property(e => e.BakiyeDurumu)
                .IsUnicode(false);

            modelBuilder.Entity<vw_CariHareket>()
                .Property(e => e.Sira)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.Sira)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.TCKimlikNo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.Maliyet)
                .HasPrecision(38, 4);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.Kar)
                .HasPrecision(38, 4);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.YuzdeKar)
                .HasPrecision(38, 6);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.IrsaliyeSeri)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.FaturaSeri)
                .IsUnicode(false);

            modelBuilder.Entity<vw_FaturaDetay>()
                .Property(e => e.BirimFiyati)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vw_FaturaDetay>()
                .Property(e => e.DovizBirimFiyati)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vw_Kullanici>()
                .Property(e => e.IsyeriAdi)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Kullanici>()
                .Property(e => e.CepTelNo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Kullanici>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Kullanici>()
                .Property(e => e.TCKimlikNo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_SatisDetayListesi>()
                .Property(e => e.SatisTarihi1)
                .IsUnicode(false);

            modelBuilder.Entity<vw_SatisDetayListesi>()
                .Property(e => e.SatisZamani1)
                .IsUnicode(false);

            modelBuilder.Entity<vw_SatisDetayListesi>()
                .Property(e => e.Miktari)
                .HasPrecision(18, 0);

            modelBuilder.Entity<vw_SatisDetayListesi>()
                .Property(e => e.IskontoOrani)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vw_SatisListesi>()
                .Property(e => e.IskontoOrani)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vw_StokDetayliHesapEkstresi>()
                .Property(e => e.BirimFiyati)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vw_StokHareketListesi>()
                .Property(e => e.Miktar)
                .HasPrecision(18, 0);

            modelBuilder.Entity<vw_StokListesi>()
                .Property(e => e.ToplamVarlik)
                .HasPrecision(29, 2);

            modelBuilder.Entity<vw_StokListesi>()
                .Property(e => e.Marka)
                .IsUnicode(false);

            modelBuilder.Entity<vw_StokSayim>()
                .Property(e => e.MarkaAdi)
                .IsUnicode(false);

            modelBuilder.Entity<vw_StokVaryantListesi>()
                .Property(e => e.ToplamAlis)
                .HasPrecision(29, 2);

            modelBuilder.Entity<vw_StokVaryantListesi>()
                .Property(e => e.ToplamSatis)
                .HasPrecision(29, 2);

            modelBuilder.Entity<vw_StokVaryantListesi>()
                .Property(e => e.ToplamVarlik)
                .HasPrecision(29, 2);

            modelBuilder.Entity<vw_StokVaryantListesi>()
                .Property(e => e.Marka)
                .IsUnicode(false);

            modelBuilder.Entity<vw_TeknikServis>()
                .Property(e => e.MarkaAdi)
                .IsUnicode(false);

            modelBuilder.Entity<vw_TeknikServis>()
                .Property(e => e.ModelAdi)
                .IsUnicode(false);

            modelBuilder.Entity<vw_TeknikServis>()
                .Property(e => e.IsyeriAdi)
                .IsUnicode(false);
        }
    }
}
