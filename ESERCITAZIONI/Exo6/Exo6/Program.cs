using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("Please entry a number? ");
            int valor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La tabella del numero inserito con il ciclo for:");

            for(i=0; i<=valor; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }

            i = 0;
            Console.WriteLine(" ");
            Console.WriteLine("**************************************************");
            Console.WriteLine("La tabella del numero inserito con il ciclo while:");

            while (i <= valor)
            {
                Console.Write(i);
                Console.Write(" ");
                i++;
            }

            i = 0;  
            Console.WriteLine(" ");
            Console.WriteLine("**************************************************");
            Console.WriteLine("La tabella del numero inserito con il ciclo do while:");

            do
            {
                Console.Write(i);
                Console.Write(" ");
                i++;
            } while (i <= valor);

            Console.ReadLine();
        }
    }
}
