using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int min = 0;
            const int max = 10;
            int valor = 0;

            do
            {
                try
                {
                    Console.Write("Please enter a number? ");
                    valor = Convert.ToInt32(Console.ReadLine());
                    
                    if(valor < min || valor > max)
                        Console.WriteLine("ERRROR VALUE ({0})", valor);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.ReadLine();
                }

            } while (valor < min || valor > max);

            switch (valor)
            {
                case 0:
                    Console.WriteLine("Il valore inserito è: {0}...", valor);
                    break;
                case 1:
                    Console.WriteLine("E un punto...");
                    break;
                case 2:
                    Console.WriteLine("E una retta...");
                    break;
                case 3:
                    Console.WriteLine("E un triangolo...");
                    break;
                case 4:
                    Console.WriteLine("E un quadrilatero...");
                    break;
                case 5:
                    Console.WriteLine("E un pentagono...");
                    break;
                case 6:
                    Console.WriteLine("E un esagono...");
                    break;
                case 7:
                    Console.WriteLine("E un ettagono...");
                    break;
                case 8:
                    Console.WriteLine("E un ottagono...");
                    break;
                case 9:
                    Console.WriteLine("Il valore inserito è: {0}...", valor);
                    break;
                case 10:
                    Console.WriteLine("Il valore inserito è: {0}...", valor);
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
