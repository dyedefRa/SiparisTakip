using SiparisTakip.Dal.Abstract.GeneralDal;
using SiparisTakip.Dal.Concrete.EntityFramework.Context;
using SiparisTakip.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EfKullaniciRepository : IKullaniciDal
    {
        SiparisTakipContext ctx = new SiparisTakipContext();

        public Kullanici Getir(int id)
        {
            return ctx.Kullanicis.FirstOrDefault(x => x.IsyeriID==id);
        }

        public Kullanici GirisYap(string kullaniciAdi, string sifre)
        {
            return ctx.Kullanicis.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre);
        }

        public int Guncelle(Kullanici entity)
        {
            throw new NotImplementedException();
        }

        public Kullanici Kaydet(Kullanici entity)
        {
            throw new NotImplementedException();
        }

        public List<Kullanici> Listele()
        {
            throw new NotImplementedException();
        }

        public List<Kullanici> Listele(Expression<Func<Kullanici, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }

        public bool Sil(Kullanici entity)
        {
            throw new NotImplementedException();
        }
    }
}
