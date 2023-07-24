using MvcCrudProje.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudProje.Bussiness.Interfaces
{
    public interface IDepartmanManager
    {
        List<Departman> HepsiniGetir();
        void Ekle(Departman departman);
        void Guncelle(Departman departman);
        void Sil(int id);
        Departman IdyeGoreGetir(int id);
    }
}
