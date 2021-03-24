using MVC_CSV_DB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVC_CSV_DB.DAL
{
    public class AnagraficaIcpContext : DbContext
    {
        public AnagraficaIcpContext() : base("AnagraficaIcpContext")
        {
            //AnagraficaIcpDB.Up();
        }

        public DbSet<Icp> icp { get; set; }
        public DbSet<Anagrafica> anagrafica { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}