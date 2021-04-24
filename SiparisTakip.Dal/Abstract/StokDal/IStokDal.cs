using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using SiparisTakip.Entity.Model;

namespace SiparisTakip.Dal.Abstract.StokDal
{
   public interface IStokDal
    {
        Stok Kaydet(Stok entity);
        List<Stok> Listele();
        List<Stok> Listele(Expression<Func<Stok, bool>> predicate);
        Stok Getir(int id);
        int Guncelle(Stok entity);
        bool Sil(int id);
        bool Sil(Stok entity);

    }
}
