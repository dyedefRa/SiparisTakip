using SiparisTakip.Dal.Abstract.GeneralDal;
using SiparisTakip.Entity.Model;
using SiparisTakip.Interface.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SiparisTakip.Bll.Managers
{
    public class FaturaManager : IFaturaService
    {
        IFaturaDal _faturaService;
        public FaturaManager(IFaturaDal faturaService)
        {
            _faturaService = faturaService;
        }
        public IQueryable FaturaRaporu(DateTime baslama, DateTime bitis)
        {
            return _faturaService.FaturaRaporu(baslama, bitis);
        }

        public Fatura Getir(int id)
        {
            return _faturaService.Getir(id);
        }

        public int Guncelle(Fatura entity)
        {
            return _faturaService.Guncelle(entity);
        }

        public Fatura Kaydet(Fatura entity)
        {
            return _faturaService.Kaydet(entity);
        }

        public List<Fatura> Listele()
        {
            return _faturaService.Listele();
        }

        public List<Fatura> Listele(Expression<Func<Fatura, bool>> predicate)
        {

            return _faturaService.Listele(predicate);
        }

        public bool Sil(int id)
        {
            return _faturaService.Sil(id);
        }

        public bool Sil(Fatura entity)
        {
            return _faturaService.Sil(entity);
        }
    }
}
