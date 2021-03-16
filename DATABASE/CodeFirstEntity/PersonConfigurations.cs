using CodeFirstEntity;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstEntity
{
    public class PersonConfigurations : EntityTypeConfiguration<Person>
    {
        public PersonConfigurations()
        {
            this.Property(s => s.Id);
                //.IsRequired();
            this.Property(s => s.Nome)
                .IsRequired()
                .HasMaxLength(20);
            this.Property(s => s.Cognome)
                .IsRequired()
                .HasMaxLength(20);
            this.Property(s => s.Email)
                .IsRequired()
                .HasMaxLength(20);
            this.Property(s => s.Password)
                .IsRequired()
                .HasMaxLength(100);
            this.Property(s => s.Telefono)
                .IsRequired()
                .HasMaxLength(15);
            this.Property(s => s.Stato)
                .IsRequired()
                .HasMaxLength(20);
            this.Property(s => s.LastLogin);
        }
    }
}