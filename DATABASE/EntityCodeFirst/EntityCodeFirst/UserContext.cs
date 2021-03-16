using System.Data.Entity;

namespace EntityCodeFirst
{
    public class UserContext : DbContext
    {
        public UserContext() : base("userDB")
        {
            Database.SetInitializer<UserContext>(new UserDBInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonConfigurations());
        }
        public DbSet<Person> Utente { get; set; }
    }
}
