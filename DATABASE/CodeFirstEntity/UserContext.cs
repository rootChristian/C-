using System.Data.Entity;

namespace CodeFirstEntity
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=UserContext")
        {
            Database.SetInitializer<UserContext>(new UserDBInitializer());
        }
        public DbSet<Person> Utente { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonConfigurations());
        }
    }

}
