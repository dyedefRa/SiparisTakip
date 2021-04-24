namespace SiparisTakip.Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Isyeri")]
    public partial class Isyeri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Isyeri()
        {
            BankaHesaps = new HashSet<BankaHesap>();
            CariStokFiyats = new HashSet<CariStokFiyat>();
            Kasas = new HashSet<Kasa>();
            StokSayims = new HashSet<StokSayim>();
            StokVaryants = new HashSet<StokVaryant>();
        }

        public int IsyeriID { get; set; }

        [StringLength(150)]
        public string IsyeriAdi { get; set; }

        public int? SektorID { get; set; }

        [StringLength(150)]
        public string VergiDairesi { get; set; }

        public decimal? VergiNo { get; set; }

        [StringLength(30)]
        public string YetkiliAdi { get; set; }

        [StringLength(30)]
        public string YetkiliSoyadi { get; set; }

        [StringLength(15)]
        public string TelNo { get; set; }

        [StringLength(15)]
        public string FaksNo { get; set; }

        [StringLength(15)]
        public string CepTelNo { get; set; }

        [StringLength(250)]
        public string Adres { get; set; }

        [StringLength(50)]
        public string Ili { get; set; }

        [StringLength(50)]
        public string Ilcesi { get; set; }

        [StringLength(30)]
        public string EMail { get; set; }

        [StringLength(50)]
        public string WebAdresi { get; set; }

        public int? PostaKodu { get; set; }

        public decimal? TicaretSicilNo { get; set; }

        public bool Aktif { get; set; }

        public int? IlID { get; set; }

        public int? IlceID { get; set; }

        public int? DepoID { get; set; }

        [StringLength(10)]
        public string SubeKodu { get; set; }

        public DateTime? KayitZamani { get; set; }

        public int? KullaniciID { get; set; }

        [StringLength(30)]
        public string MaccAdress { get; set; }

        public bool? AnaSube { get; set; }

        public bool? ETicaretSube { get; set; }

        [StringLength(10)]
        public string MobilBaglantiKodu { get; set; }

        [StringLength(10)]
        public string MobilBaglantiSifresi { get; set; }

        public bool MobilBaglantiAktif { get; set; }

        public virtual Ayarlar Ayarlar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankaHesap> BankaHesaps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CariStokFiyat> CariStokFiyats { get; set; }

        public virtual Sektor Sektor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kasa> Kasas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StokSayim> StokSayims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StokVaryant> StokVaryants { get; set; }
    }
}
