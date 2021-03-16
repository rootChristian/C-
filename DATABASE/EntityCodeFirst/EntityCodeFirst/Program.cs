using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            using (var ctx = new UserContext())
            {
                var person = new Person() { lastName = "Bill" };

                ctx.Utente.Add(person);
                ctx.SaveChanges();
            }*/
            Console.WriteLine("User added...");
            Console.ReadLine();
        }
    }
}
