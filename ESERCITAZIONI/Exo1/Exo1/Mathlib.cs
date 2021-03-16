using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    class Mathlib : Geometry
    {
        // Method circle
        public Double CircumferenceCircle(Double r)
        {
            Geometry geometry = new Geometry();
            geometry.Radius = r;
            Double result = val*cstCircle*geometry.Radius;
            return result;
        }

        // Method circle
        public Double AreaCircle(Double r)
        {
            Geometry geometry = new Geometry();
            geometry.Radius = r;
            Double result = cstCircle*geometry.Radius*geometry.Radius;
            return result;
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
                    if (valor < 0)
                    { 
                        Console.WriteLine("Negative value!!!");
                        success = false;
                    }
                    else
                    {
                        success = true;
                    }
                    
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
