using System.Data.Entity.ModelConfiguration;

namespace EntityCodeFirst
{
    public class PersonConfigurations : EntityTypeConfiguration<Person>
    {
        public PersonConfigurations()
        {
            this.Property(s => s.id)
                .IsRequired();
            this.Property(s => s.lastName)
                .IsRequired()
                .HasMaxLength(20);
            this.Property(s => s.firstName)
                .IsRequired()
                .HasMaxLength(20);
            this.Property(s => s.email)
                .IsRequired()
                .HasMaxLength(20);
            this.Property(s => s.password)
                .IsRequired()
                .HasMaxLength(100);
            this.Property(s => s.telefono)
                .IsRequired()
                .HasMaxLength(10);
            this.Property(s => s.stato)
                .IsRequired()
                .HasMaxLength(20);
            this.Property(s => s.lastLogin);
                
        }
    }
}