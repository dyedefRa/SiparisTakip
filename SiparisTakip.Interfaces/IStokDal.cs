using System;
using System.Collections.Generic;
using System.Text;
using SiparisTakip.Entity.Model;

namespace SiparisTakip.Interfaces
{
    interface IStokDal
    {
        Stok Kaydet(Stok entity);
        List<Stok> Listele();
        Stok Getir(int id);
        int Guncelle(Stok entity);
        bool Sil(int id);
        bool Sil(Stok entity);

    }
}
