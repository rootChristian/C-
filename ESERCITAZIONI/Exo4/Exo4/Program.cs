using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Double valor1 = 0.0;
            Double valor2 = 0.0;
            char carattere;
            
            try
            {
                Console.Write("Please enter a first number? ");
                valor1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter a second number? ");
                valor2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the operation? ");
                carattere = Convert.ToChar(Console.ReadLine());

                switch (carattere)
                {
                    case '+':
                        Console.WriteLine("La somma tra {0} e {1} vale: {2}", valor1, valor2, valor1 + valor2);
                        break;
                    case '-':
                        Console.WriteLine("La differenza tra {0} e {1} vale: {2}", valor1, valor2, valor1 - valor2);
                        break;
                    case '*':
                        Console.WriteLine("La moltiplicazione tra {0} e {1} vale: {2}", valor1, valor2, valor1 * valor2);
                        break;
                    case '/':
                        Console.WriteLine("La divisione tra {0} e {1} vale: {2}", valor1, valor2, valor1 / valor2);
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
            
        }
    }
}
