using MvcCrudProje.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudProje.Data.Context
{
    public class CrudDbContext : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


        public CrudDbContext()
        {
            Database.Connection.ConnectionString = @"Server=.;Database=MvcCrudProje;User Id=sa;Password=1234;";
        }


        public DbSet<Calisan> Calisan { get; set; }
        public DbSet<Departman> Departman { get; set; }

    }
}
