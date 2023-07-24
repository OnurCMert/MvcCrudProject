using MvcCrudProje.Bussiness.Managers;
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
    public class DepartmanController : Controller
    {
        // GET: Departman
        GenericRepository<Departman> repo = new GenericRepository<Departman>();
        CrudDbContext db = new CrudDbContext();

        // GET: Calisan
        public ActionResult Index()
        {
            List<Departman> calisanlar = repo.HepsiniGetir();
            return View(calisanlar);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View("Ekle");
        }

        [HttpPost]
        public ActionResult Ekle(Departman departman)
        {
            repo.Ekle(departman);
            return RedirectToAction("Index", "Departman");
        }

        [HttpGet]
        public ActionResult Guncelle()
        {
            return View("Guncelle");
        }

        [HttpPost]
        public ActionResult Guncelle(Departman departman)
        {
            repo.Guncelle(departman);
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            repo.Sil(id);
            return RedirectToAction("Index");
        }

    }
}