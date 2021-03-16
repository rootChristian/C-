using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeFirstEntity.Person;

namespace CodeFirstEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UserContext())
            {

                var person = new Person
                {
                    //id = 10,
                    Nome = "Khan",
                    Cognome = "Ali",
                    Email = "ali@gmail.com",
                    Password = "34464fvfegg4eger5g4",
                    Telefono = "2453458545",
                    Stato = status.attivo.ToString(),
                    LastLogin = DateTime.Now

                };

                context.Utente.Add(person);
                Console.WriteLine(person.Cognome);
                context.SaveChanges();

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
