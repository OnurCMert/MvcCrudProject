﻿using MvcCrudProje.Bussiness.Managers;
using MvcCrudProje.Bussiness.Repository.GenericRepositoryManager;
using MvcCrudProje.Data.Context;
using MvcCrudProje.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCrudProje.Controllers
{
    public class CalisanController : Controller
    {
        GenericRepository<Calisan> repo = new GenericRepository<Calisan>();
        CrudDbContext db = new CrudDbContext();

        // GET: Calisan
        public ActionResult Index()
        {
            List<Calisan> calisanlar = repo.HepsiniGetir();
            return View(calisanlar);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View("Ekle");
        }

        [HttpPost]
        public ActionResult Ekle(Calisan calisan)
        {
            repo.Ekle(calisan);
            return RedirectToAction("Index", "Calisan");
        }

        [HttpGet]
        public ActionResult Guncelle()
        {
            return View("Guncelle");
        }

        [HttpPost]
        public ActionResult Guncelle(Calisan calisan)
        {
            repo.Guncelle(calisan);
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            repo.Sil(id);
            return RedirectToAction("Index");
        }


    }
}