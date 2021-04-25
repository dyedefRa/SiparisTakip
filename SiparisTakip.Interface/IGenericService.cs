using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SiparisTakip.Interface
{
    public interface IGenericService<T> where T : class
    {

        T Kaydet(T entity);
        List<T> Listele();
        List<T> Listele(Expression<Func<T, bool>> predicate);
        T Getir(int id);
        int Guncelle(T entity);
        bool Sil(int id);
        bool Sil(T entity);

    }
}
