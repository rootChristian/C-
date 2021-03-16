using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int len = 0;
            int valor = 0;
            int result = 0;
            int[] binary;

            Console.Write("Please insert a length of binary? ");
            len = Convert.ToInt32(Console.ReadLine());
            binary = new int[len];

            for (i = 0; i < len; i++)
            {
                Console.Write("\nPlease insert a binary number? ");
                valor = Convert.ToInt32(Console.ReadLine());

                while (valor < 0 || valor > 1)
                {
                    Console.Write("\nError, please insert a correct number? ");
                    valor = Convert.ToInt32(Console.ReadLine());
                }
                binary[i] = valor;
            }

            Console.Write("\nA binary number is: ");
            for (i = len - 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }

            for (i = 0; i < len; i++)
            {
                result += binary[i] * Convert.ToInt32(Math.Pow(2, i));
            }

            Console.Write("\nA number insert has for decimal {0}", result);
            Console.ReadLine();
        }
    }
}
