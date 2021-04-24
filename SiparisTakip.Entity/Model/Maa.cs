namespace SiparisTakip.Entity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Maa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Maa()
        {
            MaasHarekets = new HashSet<MaasHareket>();
        }

        [Key]
        public int MaasID { get; set; }

        public int? PersonelID { get; set; }

        public byte? Ay { get; set; }

        public short? Yil { get; set; }

        public decimal? MaasTutari { get; set; }

        public decimal? BankayaYatanTutar { get; set; }

        public decimal? MaxAvansTutari { get; set; }

        public int? KullaniciID { get; set; }

        public DateTime? KayitZamani { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }

        public int? MaasTutariParaTuruID { get; set; }

        public int? MaxAvansTutariParaTuruID { get; set; }

        public virtual Personel Personel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaasHareket> MaasHarekets { get; set; }
    }
}
