using MvcCrudProje.Bussiness.Interfaces;
using MvcCrudProje.Data.Context;
using MvcCrudProje.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudProje.Bussiness.Managers
{
    public class CalisanManager : ICalisanManager
    {
        public void Ekle(Calisan calisan)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                db.Calisan.Add(calisan);
                db.SaveChanges();
            }
        }

        public void Guncelle(Calisan calisan)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                db.Entry(calisan).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Calisan> HepsiniGetir()
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                return db.Calisan.ToList();
            }
        }

        public void Sil(int id)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                var silinecekCalisan = db.Calisan.Find(id);
                db.Calisan.Remove(silinecekCalisan);
                db.SaveChanges();
            }
        }

      
    }
}
