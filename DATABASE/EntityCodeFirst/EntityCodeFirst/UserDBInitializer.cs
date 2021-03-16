using CodeFirstEntity;
using System.Collections.Generic;
using System.Data.Entity;

namespace CodeFirstEntity
{
    public class UserDBInitializer : DropCreateDatabaseAlways<UserContext>
    {
        private static void AddUtente()
        {

            using (var context = new UserContext())
            {

                var person = new Person
                {
                    id = 10,
                    lastName = "Khan",
                    firstName = "Ali",
                    email = "ali@gmail.com",
                    password = "34464fvfegg4eger5g4",
                    //stato = Person.status.attivo,

                };

                context.Utente.Add(person);
                context.SaveChanges();

            }
        }
    }
    
}