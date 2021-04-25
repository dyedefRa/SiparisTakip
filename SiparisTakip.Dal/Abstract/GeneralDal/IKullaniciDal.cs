using SiparisTakip.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.GeneralDal
{
   public interface IKullaniciDal:IGenericDal<Kullanici>
    {
        Kullanici GirisYap(string kullaniciAdi, string sifre);
    }
}
