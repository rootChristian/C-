using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2
{
    class Mathlib
    {
        // Method circle
        public void NatureGeometry(Double a, Double b, Double c)
        {
            Geometry geometry = new Geometry();
            geometry.Side_A = a;
            geometry.Side_B = b;
            geometry.Side_C = c;
            
            Double result_c =  geometry.Side_A + geometry.Side_B;
            Double result_b = geometry.Side_A + geometry.Side_C;
            Double result_a = geometry.Side_B + geometry.Side_C;


            if(result_a > geometry.Side_A || result_b > geometry.Side_B || result_c > geometry.Side_C)
            {
                
                if (geometry.Side_A == geometry.Side_B && geometry.Side_A == geometry.Side_C && geometry.Side_B == geometry.Side_C)
                {
                    Console.WriteLine("TRIANGOLO EQUILATERO...");
                }
                else if(geometry.Side_A == geometry.Side_B || geometry.Side_A == geometry.Side_C || geometry.Side_B == geometry.Side_C)
                {
                    Console.WriteLine("TRIANGOLO ISOSCELE...");
                }
                else
                {
                    Console.WriteLine("TRIANGOLO SCALENO...");
                }
            }
            else
            {
                Console.WriteLine("NATURA DEL TRIANGOLO INDEFINITO!");
            }

        }

        // Function check input
        public Double CheckParameter(string sms, Double valor)
        {
            Boolean success = true;
            do
            {

                try
                {
                    Console.Write(sms);
                    valor = Convert.ToDouble(Console.ReadLine());
                    /* if (valor < 0)
                     {
                         Console.WriteLine("Negative value!!!");
                         success = false;
                     }
                     else
                     {
                         success = true;
                     }*/
                    success = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine("Please enter the correct value (Double)");
                    Console.ReadLine();
                    Console.Clear();
                    success = false;
                }

            } while (!success);

            return valor;
        }
    }
}
