using SiparisTakip.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Interface.IServices
{
   public interface IKullaniciService:IGenericService<Kullanici>
    {
        Kullanici GirisYap(string kullaniciAdi, string parola);
    }
}
