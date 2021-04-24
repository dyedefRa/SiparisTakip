using SiparisTakip.Dal.Abstract.StokDal;
using SiparisTakip.Dal.Concrete.EntityFramework.Context;
using SiparisTakip.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EfStokRepository : IStokDal
    {
        SiparisTakipContext ctx = new SiparisTakipContext();

        public Stok Getir(int id)
        {
            return ctx.Stoks.Where(x => x.StokID == id).FirstOrDefault();
        }

        public int Guncelle(Stok entity)
        {
            ctx.Stoks.AddOrUpdate(entity);
            return ctx.SaveChanges();
        }

        public Stok Kaydet(Stok entity)
        {
            ctx.Stoks.Add(entity);
            ctx.SaveChanges();
            return entity;
        }

        public List<Stok> Listele()
        {
           return ctx.Stoks.ToList();
        }

        public List<Stok> Listele(Expression<Func<Stok, bool>> predicate)
        {
            return ctx.Stoks.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            return Sil(Getir(id));
        }

        public bool Sil(Stok entity)
        {
            ctx.Stoks.Remove(entity);
            return ctx.SaveChanges()>0;
        }
    }
}
