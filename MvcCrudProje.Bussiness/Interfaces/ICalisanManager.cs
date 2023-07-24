using MvcCrudProje.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudProje.Bussiness.Interfaces
{
    public interface ICalisanManager
    {
        List<Calisan> HepsiniGetir();
        void Ekle(Calisan calisan);
        void Guncelle(Calisan calisan);
        void Sil(int id);
    }
}
