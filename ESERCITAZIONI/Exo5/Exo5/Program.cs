using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo5
{
	
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            Console.Write("Please enter a number? ");
            valor = Convert.ToInt32(Console.ReadLine());

			int i, j;
			int t;

			for (i = 0; i < valor - 1; i++)
			{
				Console.Write("*");

				t = valor * i / valor;
				if (t>0)
				{
					for (j = 0; j < (t - 1); j++)
					{
						Console.Write("*");
					}
					Console.Write("*");
				}

				Console.Write("\n");
			}

			for (j = 0; j < valor; j++)
			{
				Console.Write("*");
			}

			Console.ReadLine();
        }
    }
}
