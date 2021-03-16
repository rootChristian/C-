using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CodeFirst.Properties
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Utente> Utente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utente>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Utente>()
                .Property(e => e.Cognome)
                .IsUnicode(false);

            modelBuilder.Entity<Utente>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Utente>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Utente>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Utente>()
                .Property(e => e.Stato)
                .IsUnicode(false);
        }
    }
}
