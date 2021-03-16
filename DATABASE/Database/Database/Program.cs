using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteToCSV csv = new WriteToCSV();
            PersonLib p1 = new PersonLib();

            //csv.AddRecord();
            //p1.InsertPerson(Person.status.attivo);
            //p1.ModifyPerson(2, Person.status.non_attivo);
            //p1.DeletePerson(3);
            p1.PrintPerson();
            csv.AddRecord();

            Console.WriteLine("Operazione eseguita, premi un tasto per terminare");
            Console.ReadLine();
        }
    }
}

