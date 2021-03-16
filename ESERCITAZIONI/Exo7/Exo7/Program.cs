using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo7
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            int resultCalcolo = 0;

            int CalcoloFattoriale(int n)
            {

                int result = 1;
                int final = 1;
                int num = n;
                if (num > 0)
                {
                    while (final <= num)
                    {
                        result *= num;
                        num--;

                    }
                }
                else
                {
                    result = final;
                }
                return result;
            }

            do
            {
                Console.Write("Please entry a number? ");
                valor = Convert.ToInt32(Console.ReadLine());
            } while (valor < 0);

            resultCalcolo = CalcoloFattoriale(valor);
            Console.Write("Il fattoriale del numero {0} vale {1} ...", valor, resultCalcolo);
            Console.ReadLine();

        }
    }
}
