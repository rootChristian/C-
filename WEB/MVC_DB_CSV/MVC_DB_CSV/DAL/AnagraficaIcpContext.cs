using MVC_DB_CSV.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVC_DB_CSV.DAL
{
    public class AnagraficaIcpContext : DbContext
    {
        public AnagraficaIcpContext() : base("AnagraficaIcpContext")
        {
        }

        public DbSet<ModelIcp> Icp { get; set; }
        public DbSet<ModelAnagrafica> Anagrafica { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}