using SiparisTakip.Dal.Abstract.GeneralDal;
using SiparisTakip.Entity.Model;
using SiparisTakip.Interface.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Managers
{
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullaniciDal;
        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        public Kullanici Getir(int id)
        {
            throw new NotImplementedException();
        }

        public Kullanici GirisYap(string kullaniciAdi, string parola)
        {
            try
            {
                var sifre = new ToPasswordRepository().Md5(parola);
           var user=   _kullaniciDal.GirisYap(kullaniciAdi, sifre);
                if (user == null)
                    throw new Exception("Kullanıcı veya Parola Uyuşmuyor.");
                else
                    return user;
            }
            catch (Exception)
            {

                throw new Exception("Kullanıcı Giriş Hatası");
            }
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
