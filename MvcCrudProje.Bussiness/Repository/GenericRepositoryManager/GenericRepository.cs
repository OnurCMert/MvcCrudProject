﻿using MvcCrudProje.Bussiness.Repository.GenericRepositoryInterface;
using MvcCrudProje.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudProje.Bussiness.Repository.GenericRepositoryManager
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        CrudDbContext db;
        DbSet<T> dbSet;

        public GenericRepository()
        {
            db = new CrudDbContext();
            this.dbSet = db.Set<T>();
        }



        public void Ekle(T entity)
        {
            dbSet.Add(entity);
            db.SaveChanges();
        }

        public void Guncelle(T entity)
        {
            dbSet.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public List<T> HepsiniGetir()
        {
            return dbSet.ToList();
        }

        public void Sil(int id)
        {
            var silinecek = dbSet.Find(id);
            dbSet.Remove(silinecek);
            db.SaveChanges();
        }
    }
}
