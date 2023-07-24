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
    public class DepartmanManager : IDepartmanManager
    {
        public void Ekle(Departman departman)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                db.Departman.Add(departman);
                db.SaveChanges();
            }
        }

        public void Guncelle(Departman departman)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                db.Entry(departman).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Departman> HepsiniGetir()
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                return db.Departman.ToList();
            }
        }

        public Departman IdyeGoreGetir(int id)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                return db.Departman.FirstOrDefault(x => x.ID == id);
            }
        }

        public void Sil(int id)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                var silinecekDepartman = db.Departman.Find(id);
                db.Departman.Remove(silinecekDepartman);
                db.SaveChanges();
            }
        }
    }
}
