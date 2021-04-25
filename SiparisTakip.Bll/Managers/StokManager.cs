using SiparisTakip.Dal.Abstract.GeneralDal;
using SiparisTakip.Entity.Model;
using SiparisTakip.Interface.IServices;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SiparisTakip.Bll.Managers
{
    public class StokManager : IStokService
    {
        IStokDal _stokService;
        public StokManager(IStokDal stokService)
        {
            _stokService = stokService;
        }

        public Stok Getir(int id)
        {
            return _stokService.Getir(id);
        }

        public int Guncelle(Stok entity)
        {
            return _stokService.Guncelle(entity);
        }

        public Stok Kaydet(Stok entity)
        {
            return _stokService.Kaydet(entity);
        }

        public List<Stok> Listele()
        {
            return _stokService.Listele();
        }

        public List<Stok> Listele(Expression<Func<Stok, bool>> predicate)
        {
            return _stokService.Listele(predicate);
        }

        public bool Sil(int id)
        {
            return _stokService.Sil(id);
        }

        public bool Sil(Stok entity)
        {
            return _stokService.Sil(entity);
        }
    }
}
